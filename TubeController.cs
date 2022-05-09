using System;

namespace LondonTube {

  class TubeController {
    List<Platform> platforms;
    List<Line> lines;
    List<Station> stations;
    List<TrackClosure> closures;
    List<TrackDelay> delays;

    GraphAdjListWeighted graph;

    public TubeController() {
      platforms = new List<Platform>();
      lines = new List<Line>();
      stations = new List<Station>();
      closures = new List<TrackClosure>();
      delays = new List<TrackDelay>();
    }
    
    private void addPlatform(Platform platform){
      try {
        // need to check that there isn't already an object at this index
        // if no object at index, catch index error and continue
        // if object at index, throw error
        var existingPlatform = platforms.getItemAtIndex(platform.ID);
        throw new InvalidOperationException($"There is already a platform at this index: {existingPlatform.ToString()}");
      }
      catch (IndexOutOfRangeException){
        // no existing platform at index, ok to add platform
      }
      platforms.InsertAtIndex(platform, platform.ID);
    }

    public Station createStation(String name){
      Station station = new Station(name);
      stations.InsertLast(station);
      return station;
    }
    
    public Line createLine(LineName lineName, Direction direction){
      Line newLine = new Line(lineName, direction);
      lines.InsertLast(newLine);

      return newLine;
    }

    public void addStationToLine(Line line, Station station){
      var platform = new Platform(line, station, platforms.getLength());
      addPlatform(platform);
      station.AddPlatform( platform );
      line.UpdateStation(station);
    }

    public void createConnection(Line sourceLine, Station source, Line targetLine, Station target, double time, ModeType mode){
      var sourcePlatform = source.GetPlatform(sourceLine);
      var targetPlatform = target.GetPlatform(targetLine);

      sourcePlatform.addConnection( new Connection(sourcePlatform, targetPlatform, time, mode) );
    }
    
    public void loadWeightedGraph(String name){
      graph = new GraphAdjListWeighted(name, platforms.getLength());
      foreach(Platform platform in platforms){
        foreach(Connection connection in platform.connections){
          graph.addEdge(connection.Source.ID, connection.Target.ID, connection.standardTime);
        }
      }
    }

    private Platform getPlatformFromInt(int id){
      if (platforms[id].ID == id){
        return platforms[id];
      }
      throw new IndexOutOfRangeException("Platform IDs do not match");
    }

    private Path<Platform> mapPathToModel(Path<int> path){

        var platformPath = new Path<Platform>(getPlatformFromInt(path.startVertex), getPlatformFromInt(path.destination));
        foreach(Edge<int> edge in path.getPath()){
          var platformEdge = new Edge<Platform>(getPlatformFromInt(edge.Source), getPlatformFromInt(edge.Target), edge.Weight);
          platformPath.InsertNode(platformEdge);
        }

      return platformPath;
    }   

    public Path<Platform> getShortestPath(Station source, Station target){
      
      var paths = new MinHeap<Path<int>>();
      
      foreach( Platform sourcePlatform in source.platforms ){
        var sp = new ShortestPath(graph, sourcePlatform.ID);

        foreach( Platform targetPlatform in target.platforms ){
          Path<int> path = sp.getShortestPathtoDestination(targetPlatform.ID);
          if (path != null){
            paths.InsertItem(path);
          }
        }
      }
      if (paths.Length == 0){
        return null;
      }

      List<Path<int>> orderedPaths = paths.Sort();
      //var la = mapPathToModel(orderedPaths.getFirstItem());
      return mapPathToModel(orderedPaths.getFirstItem());

    }


    private void validateTrackConnection(Platform source, Platform target){
        // check if target is after source

        var platform = source;
        while(platform != target || platform == null) {
          var connection = platform.getNextConnectionOnLine();
          if (connection.Target == target){
            return;
          }
          platform = connection.Target;
        }

        throw new InvalidOperationException("Target platform does not follow source platform on line");
    }

    public TrackClosure CloseSectionOfTrack(Line line, Station source, Station target, String reason){

      var platform = source.GetPlatform(line);
      var targetPlatform = target.GetPlatform(line);

      validateTrackConnection(platform, targetPlatform);
      
      TrackClosure closure = new TrackClosure(reason);

      while(platform != targetPlatform){       
        var connection = platform.getNextConnectionOnLine();

        if (connection.Closure != null){
          throw new InvalidOperationException($"Connection from {connection.Source.Station.Name} to {connection.Target.Station.Name} already closed");
        }

        connection.Closure = closure;
        closure.addElement(connection);
        graph.removeEdge(connection.Source.ID, connection.Target.ID );
        
        platform = connection.Target;
      }

      closures.InsertLast(closure);

      return closure;

    }

    public void ReopenSectionOfTrack(TrackClosure closure){
      foreach(Connection connection in closure.getElements()){
        connection.Closure = null;
        graph.addEdge(
          connection.Source.ID, 
          connection.Target.ID, 
          connection.Delay == null ? connection.standardTime : connection.Delay.Time + connection.standardTime
        );
      }

      closures.RemoveItem(closure);
    }

    public TrackDelay AddDelayToLine(Line line, Station source, String reason, Double time){
      // user needs to add delays to specific connections between stations
      // any connections with a delay need to be added to a delay object
      // a delay object should contain all adjacent connections with a delay
      // this creates a track section of delays
      // user can then clear a whole section of delays in one go

      //var connection = validateDelay(source.GetPlatform(line), target.GetPlatform(line));
      var connection = source.GetPlatform(line).getNextConnectionOnLine();

      var trackDelay = new TrackDelay(reason);
      var delay = new Delay(connection, trackDelay, time);

      trackDelay.Insert(delay);
      delays.InsertLast(trackDelay);

      connection.Delay = delay;
      
      graph.modifyEdge(connection.Source.ID, connection.Target.ID, connection.standardTime + time);
      
      return trackDelay;

    }

    public void ExpandDelay(TrackDelay trackDelay, Double time) {

      if ( time <= 0 ) {
        throw new InvalidOperationException("Delay time must be greater than zero");
      }

      var lastDelay = trackDelay.getLastDelay();
      var connection = lastDelay.Connection.Target.getNextConnectionOnLine();

      var delay = new Delay(connection, trackDelay, time);
      trackDelay.Insert(delay);
      connection.Delay = delay;
      
      graph.modifyEdge(connection.Source.ID, connection.Target.ID, connection.standardTime + time);
      
    }

    public void RemoveDelay(TrackDelay trackDelay){

      foreach(var delay in trackDelay.getDelays()) {
        var connection = delay.Connection;
        graph.modifyEdge(connection.Source.ID, connection.Target.ID, connection.standardTime);

        connection.Delay = null;

      }
      
      delays.RemoveItem(trackDelay);

    }
    
    public List<Station> getStations()
    {
        return stations;
    }
    
    public List<TrackClosure> getClosures()
    {
        return closures;
    }
    
    public List<TrackDelay> getDelays()
    {
        return delays;
    }
    
    public List<Line> getLines()
        {
            return lines;
        }
    }
} 