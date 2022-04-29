using System;

namespace LondonTube {
  class TrackClosure {

    LinkedList<Connection> elements;

    String Reason {get;}

    public TrackClosure(String reason){
      elements = new LinkedList<Connection>();
      this.Reason = reason;
    }

    public void addElement(Connection connection){

      if (elements.Length == 0){
        elements.InsertFirst(connection);
      }
      else {
        if (connection.Target == elements.Head.Data.Source){
          elements.InsertFirst(connection);
        }
        else if (connection.Source == elements.Tail.Data.Target){
          elements.InsertLast(connection);
        }
        else{
          throw new InvalidOperationException("Delay is not linked to this TrackDelay object");
        }
      }
    }

    public LinkedList<Connection> getElements(){
      return elements;
    }

  }

}
