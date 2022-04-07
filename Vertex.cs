using System;

namespace Tutorial_9
{
    class Vertex
    {
        private int    vertexID ;
        private Object vertexData ;

        public Vertex(int vertexID, Object vertexData)
        {
            this.vertexID   = vertexID;
            this.vertexData = vertexData;
        }

        public int getID()
        {
            return vertexID;
        }

        public Object getData()
        {
            return vertexData;
        }

        public void Print()
        {
            Console.WriteLine("Verex[ ID: " + vertexID + ", Data: " + vertexData.ToString()  + " ]");
        }

    } // Vertex	
}
