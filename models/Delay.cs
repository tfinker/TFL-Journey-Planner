using System;

namespace LondonTube {
  class Delay {
    public Double Time {get;}
    public TrackDelay TrackDelay {get;}
    public Connection Connection {get;}

    public Delay(Connection connection, TrackDelay trackDelay, Double time){
      
      Connection = connection;
      TrackDelay = trackDelay;
      Time = time;
    }
  }
}