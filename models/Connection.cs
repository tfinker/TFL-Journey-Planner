using System;

namespace Tutorial_9 {
  
  enum ModeType {
    Tube,
    Interchange
  }

  class Connection {
    public Platform Source;
    public Platform Target;
    public int standardTime;
    public ModeType mode;

    public Connection(Platform source, Platform target, int time, ModeType mode) {
      this.Source = source;
      this.Target = target;
      this.standardTime = time;
      this.mode = mode;
    }
  }
}