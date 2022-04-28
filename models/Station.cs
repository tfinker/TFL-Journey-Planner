using System;

namespace Tutorial_9 {
  class Station {

    // TODO: Binary search tree to identify duplicate names quickly
    //static String[] names;
    public string Name {get;set;}
    public Platform[] platforms;

    static Station() {
     // names = new String[0];
    }

    public Station(string name) {
      // validateName(name);
     // TubeController.InsertIntoArray<String>(ref names, name);
      Name = name;
      platforms = new Platform[0];
    }

    // private void validateName(string newName){
    //   foreach(String name in names){
    //     if (name.Equals(newName)) {
    //       throw new TubeModelException($"Station {newName} alredy exists");
    //     }
    //   }
    // }

    public void AddPlatform(Platform platform){

      Array.Resize(ref platforms, platforms.Length+1);
      platforms[platforms.Length-1] = platform;

    }

    public Platform GetPlatform(Line line){
      foreach(Platform platform in platforms){
        if (platform.Line.Equals(line)) {
          return platform;
        }
      }
      return null;
    }

    

    override public String ToString(){
       
      var str = $"Station: {Name}";
      foreach(Platform platform in platforms){
        str += $"\n\t Platform: {platform.Line.Name.ToString()} {platform.Line.Direction.ToString()}";
      }
      return str;
    }
  }
}