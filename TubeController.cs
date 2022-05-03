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
      line.addStation(station);
    }

    public void createConnection(Line sourceLine, Station source, Line targetLine, Station target, int time, ModeType mode){
      var sourcePlatform = source.GetPlatform(sourceLine);
      var targetPlatform = target.GetPlatform(targetLine);

      sourcePlatform.addConnection( new Connection(sourcePlatform, targetPlatform, time, mode) );
    }


    public void PrintModel(){

      foreach(Line line in lines){
        Console.WriteLine(line.ToString());
      }

      foreach(Station station in stations){
        Console.WriteLine(station.ToString());
      }

      foreach(Platform platform in platforms){
        Console.WriteLine(platform.ToString());
      }
    }

    public void printGraph(){
      graph.Print();
    }

    public int getVertexCount(){
      return platforms.getLength();
    }
    public void loadWeightedGraph(String name){
      graph = new GraphAdjListWeighted(name, getVertexCount());
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

    private List<Path<Platform>> mapPathsToModel(List<Path<int>> paths){
      var platformPaths = new List<Path<Platform>>();

      foreach(var path in paths){
        var pPath = new Path<Platform>(getPlatformFromInt(path.startVertex), getPlatformFromInt(path.destination));
        foreach(Edge<int> edge in path.getPath()){
          var platformEdge = new Edge<Platform>(getPlatformFromInt(edge.Source), getPlatformFromInt(edge.Target), edge.Weight);
          pPath.InsertNode(platformEdge);
        }
        platformPaths.InsertLast(pPath);
      }

      return platformPaths;
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
      List<Path<int>> orderedPaths = paths.Sort();

      List<Path<Platform>> tubePaths = mapPathsToModel(orderedPaths);

      return tubePaths.getFirstItem();
    }


    public void printPath(Path<Platform> path) {

        String getTimeString(int time){
          return $"{time} min" + (time > 1 ? "s" : "");
        }
        
        Console.WriteLine($"Path from {path.startVertex.Station.Name} to {path.destination.Station.Name}");
        Console.WriteLine($" - {path.startVertex.Line.Name}: {path.startVertex.Station.Name} ({path.startVertex.Line.Direction})");
        
        int segmentTime=0;
        foreach(Edge<Platform> edge in path.getPath()){
          var connection = edge.Source.getConnection(edge.Target);

          if (connection.mode == ModeType.Interchange) {
            Console.WriteLine($" - {getTimeString(segmentTime)}");
            Console.WriteLine($" - {edge.Source.Line.Name}: {edge.Source.Station.Name} ({edge.Source.Line.Direction}) --  ");
            Console.WriteLine($"Change lines {edge.Weight} min" + (edge.Weight > 1 ? "s":""));
            Console.WriteLine($" - {edge.Target.Line.Name}: {edge.Target.Station.Name} ({edge.Target.Line.Direction}) ");
          }
          else {
            segmentTime += edge.Weight;
          }
        }
        Console.WriteLine($" - {getTimeString(segmentTime)}");
        Console.WriteLine($" - {path.destination.Line.Name}: {path.destination.Station.Name} ({path.destination.Line.Direction}) ");

        Console.WriteLine($"\n--Total time: {getTimeString(path.weight)}");
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



    private Connection validateDelay(Platform source, Platform target){

      var connection = source.getNextConnectionOnLine();

      if (connection.Target != target){
        throw new InvalidOperationException($"Target platform does not match connection");
      }

      if (connection.Delay != null){
        throw new InvalidOperationException($"Connection from {connection.Source.Station.Name} to {connection.Target.Station.Name} already has delay");
      }

      return connection;
    }

    public TrackDelay AddDelayToLine(Line line, Station source, Station target, String reason, int time){
      // user needs to add delays to specific connections between stations
      // any connections with a delay need to be added to a delay object
      // a delay object should contain all adjacent connections with a delay
      // this creates a track section of delays
      // user can then clear a whole section of delays in one go

      var connection = validateDelay(source.GetPlatform(line), target.GetPlatform(line));

      var trackDelay = new TrackDelay(reason);
      var delay = new Delay(connection, trackDelay, time);

      trackDelay.Insert(delay);
      delays.InsertLast(trackDelay);

      connection.Delay = delay;
      
      graph.modifyEdge(connection.Source.ID, connection.Target.ID, connection.standardTime + time);
      
      return trackDelay;

    }


    public void ExpandDelay(TrackDelay trackDelay, Station source, Station target, int time) {

      if ( time <= 0 ) {
        throw new InvalidOperationException("Delay time must be greater than zero");
      }

      var connection = validateDelay(source.GetPlatform(trackDelay.GetLine()), target.GetPlatform(trackDelay.GetLine()));

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
  }

}  