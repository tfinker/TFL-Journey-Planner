using System;
using System.Collections.Generic;


namespace Tutorial_9
{
    class Path
    {
      private List<(int,int)> path;

      public Path(){

        path = new List<(int, int)> {};
      }

      public void Add(int from, int to){
        path.Add((from, to));

      }

      public List<(int, int)> getSpecificPath(int start, int end) {
        
        var specificPath = new List<(int, int)> {};
        var reversedPath = new List<(int,int)>{};
        reversedPath.AddRange(path);
        reversedPath.Reverse();

        foreach(var (s,e) in reversedPath){

          if (end == e) {
            specificPath.Insert(0, (s,e));
            if (start == s){
              return specificPath;
            }
          }
          else if ((specificPath.Count>0) && (e == specificPath[0].Item1)){
            specificPath.Insert(0, (s,e));
            if (start == s){
              return specificPath;
            }
          }

        }

        return null;
      }




    }

}
