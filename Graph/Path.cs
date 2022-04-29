using System;
//using System.Collections.Generic;


namespace LondonTube
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



    }

}
