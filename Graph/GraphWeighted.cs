﻿using System;

namespace Tutorial_9
{
    abstract class GraphWeighted : IGraphWeighted
    {

        protected string  graphName    = "Unknown" ;
        protected int     cardVertices = 0 ;
        private int[,]  Edges ;

        protected int cardEdges = 0;  // updated when add or delete an edge

        public GraphWeighted( String graphName, int numberOfVertices )
        {
            this.graphName    = graphName ;
            this.cardVertices = numberOfVertices;
        }

        public GraphWeighted(String graphName, int numberOfVertices, int[,] Edges )
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
        abstract public bool addEdge(int sourceVertex, int destinationVertex, int Weight) ;

        // remove edge "(sV, dV)" from the graph
        abstract public bool removeEdge(int sourceVertex, int destinationVertex) ;

        // modify edge "(sV, dV)" of the graph
        abstract public bool modifyEdge(int sourceVertex, int destinationVertex, int weight) ;

        // check if 2 vertices sV  dV are adjacent, i.e. neighbours   
        abstract public bool isAdjacent(int sourceVertex, int destinationVertex);
        abstract public void Print();





    }
}
