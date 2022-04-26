using System;

namespace Tutorial_9 {
  enum Direction {
    Westbound,
    Eastbound,
    Northbound,
    Southbound,
    Clockwise,
    Anticlockwise
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

    public LinkedList stations;

    public Line(LineName name, Direction direction){
      Name = name;
      Direction = direction;
      stations = new LinkedList();
      
    }

    public void addStation(Station station) {
      stations.InsertAtTail(station);
    }

    override public String ToString(){
      return $"Line: {Name.ToString()}, Direction: {Direction.ToString()}";
    }

  }
}