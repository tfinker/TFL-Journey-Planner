using System;


namespace LondonTube
{
    class GraphAdjListWeighted : GraphWeighted
    {

        protected LinkedList<Edge<int>>[] AL;

        public GraphAdjListWeighted(String graphName, int numberOfVertices)
               : base(graphName, numberOfVertices)
        {
            AL = new LinkedList<Edge<int>>[numberOfVertices];
            for (int i=0; i<numberOfVertices;i++) {
              AL[i] = new LinkedList<Edge<int>>();
            }
        }


        private bool validVertex(int vertex)
        {
            return (0 <= vertex & vertex <= numberOfVertices() - 1);
        }

        override public bool addEdge(int sourceVertex, int destinationVertex, int weight)
        {
            if ( validVertex(sourceVertex) & validVertex(destinationVertex) )
            {
              if ( !isAdjacent(sourceVertex, destinationVertex) ) {

                getEdgeList(sourceVertex).InsertLast(new Edge<int>(sourceVertex, destinationVertex, weight));

                cardEdges++;

                Console.WriteLine("Edge ({0}, {1}) added to graph", sourceVertex, destinationVertex);
                return true;
              }
              else {
                Console.WriteLine("Edge ({0}, {1}) Already exists", sourceVertex, destinationVertex);
                return false;
              }
            }
            else
            {
                Console.WriteLine("Edge ({0}, {1}) INVALID - Not added to graph", sourceVertex, destinationVertex);
                return false;
            }

        }

        override public bool removeEdge(int sourceVertex, int destinationVertex)
        {
            if ( validVertex(sourceVertex) & validVertex(destinationVertex) )
            {
                if (isAdjacent(sourceVertex, destinationVertex))
                {
                    // remove edge "(sV, dV)" from the graph

                    foreach(var edge in getEdgeList(sourceVertex)) {
                      if (edge.Target == destinationVertex) {
                        AL[sourceVertex].RemoveItem(edge);
                        break;
                      }
                    }

                    this.cardEdges--;

                    Console.WriteLine("Edge ({0}, {1}): Deleted", sourceVertex, destinationVertex);
                    return true;
                }
                else
                {
                    Console.WriteLine("Edge ({0}, {1}): Cannot Delete - Does Not Exist", sourceVertex, destinationVertex);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Edge ({0}, {1}) INVALID - Not deleted from graph", sourceVertex, destinationVertex);
                return false;
            }
        }

        override public bool modifyEdge(int sourceVertex, int destinationVertex, int weight){
          if (validVertex(sourceVertex) & validVertex(destinationVertex)) {
          
            foreach(var edge in getEdgeList(sourceVertex)) {
              if (edge.Target == destinationVertex){
                edge.Weight = weight;
                return true;
              }
            }
          }
          return false;
        }

        override public bool isAdjacent(int sourceVertex, int destinationVertex)
        {

            if (validVertex(sourceVertex) & validVertex(destinationVertex))
            {
              foreach(var edge in getEdgeList(sourceVertex)) {
                if ( destinationVertex == edge.Target ) {
                  return true;
                }
              }
              return false;
            }
            else
            {
                Console.WriteLine("isAdjacent: FAILED - INVALID Edge ({0}, {1})", sourceVertex, destinationVertex);
                return false;
            }
        }

        public LinkedList<Edge<int>> getEdgeList(int vertex) {
          return AL[vertex];
        }

        override public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Graph: {0}, Card(V) = {1}, card(E) = {2}", 
                                      graphName,     cardVertices,  cardEdges  ) ;
            Console.WriteLine("Edges:" ) ;

            for (int sourceVertex = 0; sourceVertex < cardVertices; sourceVertex++)
            {
                foreach(var edge in getEdgeList(sourceVertex)) {
                    Console.WriteLine(edge.Source + " --> " + edge.Target + " == " + edge.Weight) ;
                }
            }

            Console.WriteLine();
        }
    } 

}



