using System;

namespace Tutorial_9 {
  class TrackDelay {

    /* TrackDelay object contains a linked list of delays on a continuous section of track.
    The delays must be added in sequence.
    Direction of delays is Head to Tail in direction of tube.
    */
    LinkedList<Delay> delays;
    public String Reason {get;}
    public TrackDelay(String reason){
      delays = new LinkedList<Delay>();
      this.Reason = reason;
    }

    public void Insert(Delay delayToAdd){
      // 
      // Either append or prepend the delay if it links to the head or tail
      // Otherwise the delayToAdd does not belong in this TrackDelay object.

      if (delays.Length == 0){
        delays.InsertAtHead(delayToAdd);
      }
      else {
        if (delayToAdd.Connection.Target == delays.Head.Data.Connection.Source){
          delays.InsertAtHead(delayToAdd);
        }
        else if (delayToAdd.Connection.Source == delays.Tail.Data.Connection.Target){
          delays.InsertAtTail(delayToAdd);
        }
        else{
          throw new InvalidOperationException("Delay is not linked to this TrackDelay object");
        }
      }
    }

    public LinkedList<Delay> getDelays(){
      return delays;
    }


    public Line GetLine(){
      return delays.Head.Data.Connection.Source.Line;
    }

    public int GetTotalDelay() {
      int totalDelay =0;

      var delay = delays.Head;
      while(delay != null){
        totalDelay += delay.Data.Time;
        delay = delay.Next;
      }
      return totalDelay;
    }

  }

}
