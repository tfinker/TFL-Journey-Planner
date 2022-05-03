using System;

namespace LondonTube {
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
        delays.InsertFirst(delayToAdd);
      }
      else {
        if (delayToAdd.Connection.Target == delays.Head.Data.Connection.Source){
          delays.InsertFirst(delayToAdd);
        }
        else if (delayToAdd.Connection.Source == delays.Tail.Data.Connection.Target){
          delays.InsertLast(delayToAdd);
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

    public Double GetTotalDelay() {
      Double totalDelay =0;

      foreach(var delay in delays) {
        totalDelay += delay.Time;
      }
      return totalDelay;
    }

  }

}
