using System;


namespace Tutorial_9
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

        public GraphAdjListWeighted(String graphName, int numberOfVertices, int[,] Edges)
               : base(graphName, numberOfVertices, Edges)
        {
            // Create the Adjacency List for the graph

            AL = new LinkedList<Edge<int>>[numberOfVertices];
            for (int i=0; i<numberOfVertices;i++) {
              AL[i] = new LinkedList<Edge<int>>();
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

                Nodes.InsertAtHead(new Edge<int>(sourceVertex, destinationVertex, weight));

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
                      var edge = node.Data;
                      if (edge.Target == destinationVertex) {
                        AL[sourceVertex].removeData(edge);
                        break;
                      }
                      node = node.Next;
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
          
            var edgeNode = AL[sourceVertex].Head;

            while(edgeNode != null){
              if (edgeNode.Data.Target == destinationVertex){
                edgeNode.Data.Weight = weight;
                return true;
              }
              edgeNode = edgeNode.Next;
            }
          }
          return false;
        }

        override public bool isAdjacent(int sourceVertex, int destinationVertex)
        {

            if (validVertex(sourceVertex) & validVertex(destinationVertex))
            {
              var node = AL[sourceVertex].Head;

              while(node != null){
                var edge = (Edge<int>) node.Data;
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

                var node = AL[sourceVertex].Head;
                
                while(node != null) {
                    var edge = node.Data;
                    Console.WriteLine(edge.Source + " --> " + edge.Target + " == " + edge.Weight) ;
                    node = node.Next;
                }

                
            }

            Console.WriteLine();
        }
    } // GraphAdjMatrix

} // Tutorial_9



