using System;

namespace LondonTube
{
    class Edge<T>
    {
        public T Source {get; set;}
        public T Target {get; set;}
        public int Weight {get; set;}
        
        public Edge(T source, T target, int weight) {
          this.Source = source;
          this.Target = target;
          this.Weight = weight;
        }
        

        public void Print()
        {
            Console.WriteLine("Edge[ Source: " + Source.ToString() + ", Target: " + Target.ToString()  + ", Weight: " + Weight +" ]");
        }

    } 
}
