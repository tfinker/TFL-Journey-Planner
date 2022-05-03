using System;


namespace LondonTube
{
    interface IGraphWeighted
    {
         String Name();

         int numberOfVertices();

         bool addEdge(int srcVertex, int destVertex, Double weight);

         bool removeEdge(int srcVertex, int destVertex);

         bool modifyEdge(int srcVertex, int destVertex, Double weight);

         bool isAdjacent(int srcVertex, int destVertex);

         void Print();
    }

}
