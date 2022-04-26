using System;


namespace Tutorial_9
{
    interface IGraph
    {
         String Name();

         int numberOfVertices();

         bool addEdge(int srcVertex, int destVertex);

         bool removeEdge(int srcVertex, int destVertex);

         bool isAdjacent(int srcVertex, int destVertex);

         void Print();
    }

}
