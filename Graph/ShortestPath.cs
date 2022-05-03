using System;


namespace LondonTube
{
    class ShortestPath
    {
      int startVertex;
      Edge<int>[] EdgeTo;
      Double[] DistTo;
      PriorityQueueHeap<QueueObject> queue;

      GraphAdjListWeighted AdjList;

      public ShortestPath(GraphAdjListWeighted adjList, int startVertex) {
        AdjList = adjList;
        EdgeTo = new Edge<int>[AdjList.numberOfVertices()];
        DistTo = new Double[AdjList.numberOfVertices()];
        queue = new PriorityQueueHeap<QueueObject>();
        this.startVertex = startVertex;


        for(int i=0;i<AdjList.numberOfVertices();i++){
          DistTo[i] = int.MaxValue;
        }

        getShortestPaths();

      }

      public void getShortestPaths(){

        DistTo[startVertex] = 0;
        queue.Enqueue(new QueueObject(startVertex, DistTo[startVertex]));
        
        while( queue.Length > 0 ) {
          var nearestVertex = (QueueObject) queue.Dequeue();

          foreach(var edge in AdjList.getEdgeList(nearestVertex.Vertex)){
            relaxEdge(edge);
          }
        }
      }

      public void printShortestPaths(){
        for(int i =0;i<AdjList.numberOfVertices();i++){
          Console.WriteLine($"Distance from {startVertex} to {i}: {DistTo[i]}");
        }
      }

      public Path<int> getShortestPathtoDestination(int destination){

        var path = new Path<int>(startVertex, destination);
        
        // work backwards through EdgeTo[] from destination to create a path from source to destination
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
          //Console.WriteLine($"Distance {DistTo[edge.Source]+edge.Weight} from {edge.Source} to {edge.Target} is less than {DistTo[edge.Target]}");
          DistTo[edge.Target] = DistTo[edge.Source] + edge.Weight;
          EdgeTo[edge.Target] = edge;
          queue.Enqueue(new QueueObject(edge.Target, DistTo[edge.Target]));
         // Console.WriteLine($"Queueing {edge.Target} distance {DistTo[edge.Target]}");
        }
      }
    }


}