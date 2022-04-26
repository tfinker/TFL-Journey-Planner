using System;

namespace Tutorial_9
{
    class Edge<T> : IComparable<Edge<T>>
    {
        public T Source {get; set;}
        public T Target {get; set;}
        public int Weight {get; set;}
        

        public Edge(T source, T target) {
          this.Source = source;
          this.Target = target;
        }

        public Edge(T source, T target, int weight) {
          this.Source = source;
          this.Target = target;
          this.Weight = weight;
        }

        public int CompareTo(Edge<T> other){

          //return 0;
          throw new NotImplementedException("Cannot compare edges");
        }
        

        public void Print()
        {
            Console.WriteLine("Edge[ Source: " + Source.ToString() + ", Target: " + Target.ToString()  + ", Weight: " + Weight +" ]");
        }

    } // Vertex	
}
