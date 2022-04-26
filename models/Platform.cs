using System;

namespace Tutorial_9 {
  class Platform {

    public int ID {get;}
    public Station Station {get;set;}
    public Line Line {get;set;}

    public Connection[] connections;

    public Platform(Line line, Station station, int id){
      this.ID = id;
      this.Station = station;
      this.Line = line;
      connections = new Connection[0];
    }

    public void addConnection(Connection connection){
      TubeController.InsertIntoArray<Connection>(ref connections, connection);
    }

    public Connection getConnection(Platform target){
      foreach(var connection in connections){
        if (connection.Target == target){
          return connection;
        }
      }
      return null;
    }

    override public String ToString(){
      var str = $"Platform: {ID}, Station: {Station.Name}, Line: {Line.Name.ToString()} {Line.Direction.ToString()}";
      foreach(Connection connection in connections){
        str += $"\n\t Connection: {connection.Target.Line.Name} {connection.Target.Station.Name} {connection.Target.Line.Direction}, Time: {connection.standardTime}, Mode: {connection.mode}";
      }
      return str;
    }
  }
}