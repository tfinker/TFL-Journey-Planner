using System;

namespace Tutorial_9 {

  public class TubeModelException : Exception {
      public TubeModelException() : base() {}
      public TubeModelException(string message) : base(message) {}
    }

  class TubeController {
    Platform[] platforms;
    Line[] lines;
    Station[] stations;

    Closure[] closures;

    GraphAdjListWeighted graph;

    public TubeController() {
      platforms = new Platform[0];
      lines = new Line[0];
      stations = new Station[0];
    }


    public void addPlatform(Platform platform){

      InsertIntoArray(ref platforms, platform);

    }

    public Station createStation(String name){
      Station station = new Station(name);
      InsertIntoArray(ref stations, station);

      return station;
    }
    public Line createLine(LineName lineName, Direction direction){
      Line newLine = new Line(lineName, direction);
      
      InsertIntoArray(ref lines, newLine);

      return newLine;
    }

    public void addStationToLine(Line line, Station station){
      var platform = new Platform(line, station, platforms.Length);
      addPlatform(platform);
      station.AddPlatform( platform );
      line.addStation(station);
    }

    public void createConnection(Line sourceLine, Station source, Line targetLine, Station target, int time, ModeType mode){
      var sourcePlatform = source.GetPlatform(sourceLine);
      var targetPlatform = target.GetPlatform(targetLine);

      sourcePlatform.addConnection( new Connection(sourcePlatform, targetPlatform, time, mode) );
    }


    static public void InsertIntoArray<T>(ref T[] array, T item){
      Array.Resize(ref array, array.Length+1);
      array[array.Length-1] = item;
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

    public int getVertexCount(){
      return platforms.Length;
    }
    public void loadWeightedGraph(String name){
      graph = new GraphAdjListWeighted(name, getVertexCount());
      foreach(Platform platform in platforms){
        foreach(Connection connection in platform.connections){
          graph.addEdge(connection.Source.ID, connection.Target.ID, connection.standardTime);
        }
      }
    }

    private void modifyEdge(int sourceVertex, int targetVertex, int weight){

    }
    
    public void addDelay(Platform sourcePlatform, Platform targetPlatform, int delay){

    }

    private Platform getPlatformFromInt(int id){
      if (platforms[id].ID == id){
        return platforms[id];
      }
      throw new IndexOutOfRangeException("Platform IDs do not match");
    }

    private List<Path<Platform>> mapPathsToTube(List<Path<int>> paths){
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
        foreach( Platform targetPlatform in target.platforms ){
          
          var sp = new ShortestPath(graph, sourcePlatform.ID);
          Path<int> path = sp.getShortestPathtoDestination(targetPlatform.ID);
          if (path != null){
            paths.InsertItem(path);
          }
      
        }
      }
      List<Path<int>> orderedPaths = paths.Sort();

      List<Path<Platform>> tubePaths = mapPathsToTube(orderedPaths);

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


    public void CloseSectionOfTrack(Line line, Station source, Station target){
      
    }
  }

}