using System;

namespace LondonTube {

  enum Direction {
    Westbound,
    Eastbound,
    Northbound,
    Southbound,
    Clockwise,
    Anticlockwise,
    Both // special case for track closures
  }

  enum LineName {
    Victoria,
    Circle,
    Piccadilly,
    Bakerloo,
    Central,
    Jubilee,
    NorthLondon,
    Northern
  }
  class Line {

    public LineName Name {get;}
    public Direction Direction {get;}

    //public LinkedList<Station> stations;
    Station First;
    Station Last;

    public Line(LineName name, Direction direction){
      Name = name;
      Direction = direction;
      //stations = new LinkedList<Station>();
      First=null;
      Last=null;
    }

    public void UpdateStation(Station station) {
      if (First == null) {
        First = station;
      }
      Last = station;
    }

    public List<Station> getStations(){
      var stations = new List<Station>();
      var connection = First.GetPlatform(this).getNextConnectionOnLine();
      stations.InsertLast(connection.Source.Station);
      while(connection != null){
        stations.InsertLast(connection.Target.Station);
        connection = connection.Target.getNextConnectionOnLine();
      }
      return stations;
    }

    public List<Station> getStationsAfter(Station station){
      var stations = new List<Station>();
      var connection = station.GetPlatform(this).getNextConnectionOnLine();
      while(connection != null){
        stations.InsertLast(connection.Target.Station);
        connection = connection.Target.getNextConnectionOnLine();
      }
      return stations;
    }

    override public String ToString(){
      return $"Line: {Name.ToString()}, Direction: {Direction.ToString()}";
    }

/*     public String PrintConnectionsOnLine(){
      var connection = First.GetPlatform(this).getNextConnectionOnLine();
      stations.InsertLast(connection.Source.Station);
      while(connection.Target != null){
        stations.InsertLast(connection.Target.Station);
        connection = connection.Target.getNextConnectionOnLine();
      }
    } */

  }
}