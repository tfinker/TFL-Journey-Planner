using System;

namespace LondonTube {
  class Delay {
    public int Time {get;}
    public TrackDelay TrackDelay {get;}
    public Connection Connection {get;}

    public Delay(Connection connection, TrackDelay trackDelay, int time){
      
      Connection = connection;
      TrackDelay = trackDelay;
      Time = time;
    }
  }
}