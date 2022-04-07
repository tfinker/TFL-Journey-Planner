using System;


namespace Tutorial_9
{
    class GraphAdjList : Graph
    {
        private const int NOT_ADJACENT = -1;
        private const int DEFAULT_WEIGHT = 1;

        protected VertexLink[] AL;

        public GraphAdjList(String graphName, int numberOfVertices)
               : base(graphName, numberOfVertices)
        {
            AL = new VertexLink[numberOfVertices];
        }

        public GraphAdjList(String graphName, int numberOfVertices, int[,] Edges)
               : base(graphName, numberOfVertices, Edges)
        {
            // Create the Adjacency List for the graph

            AL = new Vertex[numberOfVertices];

            foreach(int vertex in numberOfVertices){
              AL[vertex] = new VertexLink(vertex, null);
            }

            // Add the edges to the Adjacency Matrix 

            int numbEdges = Edges.GetLength(0); // size of 1st dimension of Edges[,]

            for (int edge = 0; edge < numbEdges; edge++)
            {
                addEdge(Edges[edge, 0], Edges[edge, 1]);
            }

        }


        private bool validVertex(int vertex)
        {
            return (0 <= vertex & vertex <= numberOfVertices() - 1);
        }

        override public bool addEdge(int sourceVertex, int destinationVertex)
        {
            if ( validVertex(sourceVertex) & validVertex(destinationVertex) )
            {
                var link = AL[sourceVertex].getLink();
                while(link == null){
                  link = link.getLink();
                }
                link.setLink(new VertexLink(destinationVertex, null);

                cardEdges++;

                Console.WriteLine("Edge ({0}, {1}) added to graph", sourceVertex, destinationVertex);
                return true;
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


                  VertexLink vertex = AL[sourceVertex];
                  if (vertex.getID() == destinationVertex) {
                    AL[sourceVertex] = vertex.getLink();
                    vertex.removeLink();
                  }
                  else {
                    while(vertex.getLink() != null){
                      if (vertex.getLink().getID() == destinationVertex) {
                        vertex.setLink(vertex.getLink().getLink());
                        vertex.getLink().removeLink();
                      }
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

        override public bool isAdjacent(int sourceVertex, int destinationVertex)
        {
            // check if edge "(sV, dV)" exists in the graph by 
            // checking if the adjacency matrix has [sV, dV] != 0.

            if (validVertex(sourceVertex) & validVertex(destinationVertex))
            {
                VertexLink vertex = AL[sourceVertex];
                while(vertex.getLink() != null) {
                  if (vertex.getID() == destinationVertex){
                    return true;
                  }
                  vertex = vertex.getLink();
                }
                return false;
            }
            else
            {
                Console.WriteLine("isAdjacent: FAILED - INVALID Edge ({0}, {1})", sourceVertex, destinationVertex);
                return false;
            }


        }

    } // GraphAdjMatrix

} // Tutorial_9



