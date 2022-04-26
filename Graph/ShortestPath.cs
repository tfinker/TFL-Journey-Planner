using System;


namespace Tutorial_9
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
    class ShortestPath
    {
      int startVertex;
      Edge<int>[] EdgeTo;
      int[] DistTo;
      PriorityQueueHeap<QueueObject> queue;

      GraphAdjListWeighted AdjList;

      public ShortestPath(GraphAdjListWeighted adjList, int startVertex) {
        AdjList = adjList;
        EdgeTo = new Edge<int>[AdjList.numberOfVertices()];
        DistTo = new int[AdjList.numberOfVertices()];
        queue = new PriorityQueueHeap<QueueObject>();
        this.startVertex = startVertex;


        for(int i=0;i<AdjList.numberOfVertices();i++){
          DistTo[i] = int.MaxValue;
        }
      }

      public void getShortestPaths(){

        DistTo[startVertex] = 0;
        queue.Enqueue(new QueueObject(startVertex, 0));
        
        while( queue.Length > 0 ) {
          
          var nearestVertex = (QueueObject) queue.Dequeue();
          Console.WriteLine($"Next vertex {nearestVertex.Vertex}");

          var edgeNode = AdjList.getEdgeList(nearestVertex.Vertex).Head;

          while(edgeNode != null){
            var edge = (Edge<int>) edgeNode.Data;
            Console.WriteLine($"Relaxing vertex {edge.Target}");
            relaxEdge(edge);
            edgeNode = edgeNode.Next;
          }
        }


      }

      public void printShortestPaths(){
        for(int i =0;i<AdjList.numberOfVertices();i++){
          Console.WriteLine($"Distance from {startVertex} to {i}: {DistTo[i]}");
        }
      }

      public Path<int> getShortestPathtoDestination(int destination){
        getShortestPaths();

        var path = new Path<int>(startVertex, destination);
        
        int index = destination;
        for( int i = 0; i< EdgeTo.Length;i++){
          var edge = EdgeTo[index];
          if (edge == null){
            return null;
          }
          path.InsertFirst(edge);
          
          index = edge.Source;
          if (index == startVertex) {
            return path;
          }
        }
        return null;


      }

      private void relaxEdge(Edge<int> edge){
        if (DistTo[edge.Target] > DistTo[edge.Source] + edge.Weight) {
          Console.WriteLine($"Distance {DistTo[edge.Source]+edge.Weight} from {edge.Source} to {edge.Target} is less than {DistTo[edge.Target]}");
          DistTo[edge.Target] = DistTo[edge.Source] + edge.Weight;
          EdgeTo[edge.Target] = edge;
          queue.Enqueue(new QueueObject(edge.Target, DistTo[edge.Target]));
          Console.WriteLine($"Queueing {edge.Target} distance {DistTo[edge.Target]}");
        }
      }
    }


}