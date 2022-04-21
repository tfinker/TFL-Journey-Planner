using System;


namespace Tutorial_9
{
    class GraphAdjListWeighted : GraphWeighted
    {

        protected LinkedList[] AL;

        public GraphAdjListWeighted(String graphName, int numberOfVertices)
               : base(graphName, numberOfVertices)
        {
            AL = new LinkedList[numberOfVertices];
        }

        public GraphAdjListWeighted(String graphName, int numberOfVertices, int[,] Edges)
               : base(graphName, numberOfVertices, Edges)
        {
            // Create the Adjacency List for the graph

            AL = new LinkedList[numberOfVertices];
            for (int i=0; i<numberOfVertices;i++) {
              AL[i] = new LinkedList();
            }

            // Add the edges to the Adjacency List 

            for (int edge = 0; edge < Edges.GetLength(0); edge++)
            {
                addEdge(Edges[edge, 0], Edges[edge, 1], Edges[edge, 2]);
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

                var Nodes = AL[sourceVertex];

                Nodes.InsertAtHead(new Edge(sourceVertex, destinationVertex, weight));

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
                    var node = AL[sourceVertex].Head;
                    while(node != null) {
                      node = node.Next;
                      var edge = (Edge) node.Data;
                      if (edge.Target == destinationVertex) {
                        break;
                      }
                    }
                    AL[sourceVertex].removeData(node);

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

        override public bool isAdjacent(int sourceVertex, int destinationVertex)
        {

            if (validVertex(sourceVertex) & validVertex(destinationVertex))
            {
              var node = AL[sourceVertex].Head;

              while(node != null){
                var edge = (Edge) node.Data;
                if ( destinationVertex ==  edge.Target ) {
                  return true;
                }
                node = node.Next;
              }
              return false;
            }
            else
            {
                Console.WriteLine("isAdjacent: FAILED - INVALID Edge ({0}, {1})", sourceVertex, destinationVertex);
                return false;
            }


        }

        public LinkedList getEdgeList(int vertex) {
          return AL[vertex];
        }

    } // GraphAdjMatrix

} // Tutorial_9



