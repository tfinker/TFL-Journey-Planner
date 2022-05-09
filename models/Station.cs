using System;

namespace LondonTube {
  class Station : IComparable<Station> {

    public string Name {get;set;}
    public List<Platform> platforms;

    public Station(string name) {
      Name = name;
      platforms = new List<Platform>();
    }

    public void AddPlatform(Platform platform){

      platforms.InsertLast(platform);

    }

    public Platform GetPlatform(Line line){
      foreach(Platform platform in platforms){
        if (platform.Line.Equals(line)) {
          return platform;
        }
      }
      return null;
    }

    public String LongString(){
       
      var str = $"Station: {Name}";
      str += "\nPlatforms:";
      foreach(Platform platform in platforms){
        str += $"\n\t - {platform.Line.Name.ToString()} ({platform.Line.Direction.ToString()})";
        if(platform.getNextConnectionOnLine().Delay != null) {
          var delay = platform.getNextConnectionOnLine().Delay;
          str+= $"\n\t\t -- Delays affecting this section of line: {delay.Time} min{(delay.Time > 1 ? "s" : "")}";
        }
        if(platform.getNextConnectionOnLine().Closure != null) {
          var closure = platform.getNextConnectionOnLine().Closure;
          str+= $"\n\t\t -- Closure affecting this station on this line between {closure.getFirst().Source.Station.Name} and {closure.getLast().Target.Station.Name}";
        }
      }
      return str;
    }

    override public String ToString(){
       
      return $"Station: {Name}";
    }

    public int CompareTo(Station other){
      if (other == null)
        return 1;
      return Name.CompareTo(other.Name);
    }
  }
}