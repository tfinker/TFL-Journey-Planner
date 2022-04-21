using System;

namespace Tutorial_9
{
    class Edge
    {
        public int Source {get; set;}
        public int Target {get; set;}
        public int Weight {get; set;}
        

        public Edge(int source, int target) {
          this.Source = source;
          this.Target = target;
        }

        public Edge(int source, int target, int weight) {
          this.Source = source;
          this.Target = target;
          this.Weight = weight;
        }

        public void Print()
        {
            Console.WriteLine("Edge[ Source: " + Source.ToString() + ", Target: " + Target.ToString()  + ", Weight: " + Weight +" ]");
        }

    } // Vertex	
}
