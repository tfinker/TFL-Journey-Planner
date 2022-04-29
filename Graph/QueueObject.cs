using System;


namespace LondonTube
{
    class QueueObject : IComparable<QueueObject> {
      public int Vertex {get;set;}
      public int Distance {get;set;}

      public QueueObject(int vertex, int distance){
        Vertex = vertex;
        Distance = distance;
      }

      public int CompareTo(QueueObject other){
        if (other == null)
          return 1;
        return Distance.CompareTo(other.Distance);
      }
    }

}