using System;
//using System.Collections.Generic;


namespace Tutorial_9
{
    class Path<T> : IComparable<Path<T>>
    {
      public T startVertex;
      public T destination;

      public int weight;

      List<Edge<T>> edges;

      public Path(T startVertex, T destination){
        this.startVertex = startVertex;
        this.destination = destination;
        edges = new List<Edge<T>>();
        weight = 0;
      }

      public void InsertNode(Edge<T> edge){
        edges.InsertLast(edge);
        weight += edge.Weight;
      }

      public void InsertFirst(Edge<T> edge){
        edges.InsertFirst(edge);
        weight += edge.Weight;
      }

      private void InsertIntoArray(ref Edge<T>[] array, Edge<T> item){
        Array.Resize(ref array, array.Length+1);
        array[array.Length-1]=item;
      }

        // edges are inserted in reverse, so this must be reversed to get correct path
      // private Edge<T>[] ReversePath(){
      //   Edge<T>[] correctPath = new Edge<T>[path.Length];
      //   Array.Copy(path, correctPath, path.Length);
      //   Array.Reverse(correctPath);
      //   return correctPath;
      // }
      public List<Edge<T>> getPath(){
        return edges;
      }

      public void Print(){
        var edges = getPath();
        Console.WriteLine($"Path from {startVertex.ToString()} to {destination.ToString()}");
        Console.WriteLine($" - {startVertex.ToString()}");
        foreach(Edge<T> edge in edges){
          Console.WriteLine($" - {edge.Target.ToString()}: {edge.Weight}");
        }
        Console.WriteLine($"\n--Total weight: {weight}");
      }

      public int CompareTo(Path<T> other){
        if (other == null){
          return 1;
        }

        return weight.CompareTo(other.weight);
      }

      // public List<(int, int)> getSpecificPath(int start, int end) {
        
      //   var specificPath = new List<(int, int)> {};
      //   var reversedPath = new List<(int,int)>{};
      //   reversedPath.AddRange(path);
      //   reversedPath.Reverse();

      //   foreach(var (s,e) in reversedPath){

      //     if (end == e) {
      //       specificPath.Insert(0, (s,e));
      //       if (start == s){
      //         return specificPath;
      //       }
      //     }
      //     else if ((specificPath.Count>0) && (e == specificPath[0].Item1)){
      //       specificPath.Insert(0, (s,e));
      //       if (start == s){
      //         return specificPath;
      //       }
      //     }

      //   }

      //   return null;
      // }




    }

}
