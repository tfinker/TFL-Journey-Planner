using System;

namespace Tutorial_9 {


  class TubeModel {
    Platform[] platforms;
    Line[] lines;
    Station[] stations;

    public TubeModel() {
      platforms = new Platform[0];
      lines = new Line[0];
      stations = new Station[0];
    }


    public void addPlatform(Platform platform){
      Array.Resize(ref platforms, platforms.Length+1);
      platforms[platforms.Length-1] = platform;
    }

    public void addStation(Station station){
      Array.Resize(ref stations, stations.Length+1);
      stations[stations.Length-1] = station;
    }
    public (Line, Station) addLine(Line line){
      Array.Resize(ref lines, lines.Length+1);
      lines[lines.Length-1] = line;

      return (line, line.stations[0]);
    }

    public void addStationToLine(Line line, Station station, int time){
      station.AddPlatformConnection(new Platform(station, line))
    }
  }

  enum Direction {
    Westbound,
    Eastbound,
    Northbound,
    Southbound,
    Clockwise,
    Anticlockwise
  }

  enum LineNames {
    Victoria,
    Circle,
    Piccadilly
  }
  class Line {

    public LineNames Name {get;}
    public Direction Direction {get;}

    public Station[] stations;

    public Line(LineNames name, Direction direction, Station firstStation){
      Name = name;
      Direction = direction;
      stations = new Station[1] {firstStation};
      firstStation.AddPlatform(new Platform(firstStation, this));

    }
  }
  class Station {

    public string Name {get;set;}
    public Platform[] platforms;

    public Station(string name) {
      Name = name;
      platforms = new Platform[0];
    }

    public void AddPlatform(Platform platform){
      Array.Resize(ref platforms, platforms.Length+1);
      platforms[platforms.Length-1] = platform;
    }

    
  }
  class Platform {

    private int ID;
    static int PlatformCounter = 0;

    Station station;
    Line line;

    public Connection[] connections;

    public Platform(Station station, Line line){
      this.ID = PlatformCounter++;
      this.station = station;
      this.line = line;
      connections = new Connection[0];
    }

    public Platform(Station station, Line line, int time, ModeType type){
      this.ID = PlatformCounter++;
      this.station = station;
      this.line = line;

      Array.Resize(ref connections, connections.Length+1);
      var lastPlatform = 
      connections[connections.Length] = new Connection()
      
    }

  }

  enum ModeType {
    Tube,
    Interchange
  }
  class Connection {
    Platform Source;
    Platform Target;
    int standardTime;
    ModeType mode;

    public Connection(Platform source, Platform target, int time, ModeType mode) {
      this.Source = source;
      this.Target = target;
      this.standardTime = time;
      this.mode = mode;
    }
  }
}