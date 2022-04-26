using System;

namespace Tutorial_9
{
    abstract class Graph : IGraph
    {

        private string  graphName    = "Unknown" ;
        private int     cardVertices = 0 ;
        private int[,]  Edges ;

        protected int cardEdges = 0;  // updated when add or delete an edge

        public Graph( String graphName, int numberOfVertices )
        {
            this.graphName    = graphName ;
            this.cardVertices = numberOfVertices;
        }

        public Graph(String graphName, int numberOfVertices, int[,] Edges )
        {
            this.graphName    = graphName;
            this.cardVertices = numberOfVertices;
            this.Edges        = Edges ;
        }


        /** Graph interface methods **/

        public string Name()
        {
            return graphName;
        }

        public int numberOfVertices()
        {
            return cardVertices ;
        }

        // add edge "(sV, dV)" to the graph
        abstract public bool addEdge(int sourceVertex, int destinationVertex) ;

        // remove edge "(sV, dV)" from the graph
        abstract public bool removeEdge(int sourceVertex, int destinationVertex) ;

        // check if 2 vertices sV  dV are adjacent, i.e. neighbours   
        abstract public bool isAdjacent(int sourceVertex, int destinationVertex);


        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Graph: {0}, Card(V) = {1}, card(E) = {2}", 
                                      graphName,     cardVertices,  cardEdges  ) ;
            Console.WriteLine("Edges:" ) ;

            for (int sourceVertex = 0; sourceVertex < cardVertices; sourceVertex++)
            {
                for (int destinationVertex = 0; destinationVertex < cardVertices; destinationVertex++)
                {
                    if ( isAdjacent( sourceVertex, destinationVertex) )
                    {
                        Console.WriteLine(sourceVertex + " --> " + destinationVertex) ;
                    }
                }
            }

            Console.WriteLine();
        }


    }
}
