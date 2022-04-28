using System;

namespace Tutorial_9 {
  class TrackClosure {

    List<Connection> elements;

    String Reason {get;}

    public TrackClosure(String reason){
      elements = new List<Connection>();
      this.Reason = reason;
    }

    public void addElement(Connection connection){
      elements.InsertLast(connection);
    }

    public List<Connection> getElements(){
      return elements;
    }

  }

}
