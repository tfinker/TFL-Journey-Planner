using System;

namespace Tutorial_9 {
  
  enum ModeType {
    Tube,
    Interchange
  }

  class Connection {
    public Platform Source {get;}
    public Platform Target {get;}
    public int standardTime {get;}
    public ModeType mode {get;}

    public TrackClosure Closure {get;set;}

    public Delay Delay {get;set;}

    public Connection(Platform source, Platform target, int time, ModeType mode) {
      this.Source = source;
      this.Target = target;
      this.standardTime = time;
      this.mode = mode;
    }


  }
}