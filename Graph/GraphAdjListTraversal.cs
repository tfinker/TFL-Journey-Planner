// using System;
// using System.Collections.Generic;


// namespace Tutorial_9
// {
//     class GraphAdjListTraversal : GraphAdjList
//     {
//       private bool[] visitedVertex;
//       private List<int> orderTraversed;

//       public GraphAdjListTraversal(String graphName, int numberOfVertices)
//                : base(graphName, numberOfVertices)
//         {
//           visitedVertex = new bool[numberOfVertices];
//           orderTraversed = new List<int>();
//         }

//         public GraphAdjListTraversal(String graphName, int numberOfVertices, int[,] Edges)
//                : base(graphName, numberOfVertices, Edges)
//         {
//           visitedVertex = new bool[numberOfVertices];
//           orderTraversed = new List<int>();

//         }

//         public void findDepthPath(int startVertex, int endVertex) {
          
//           var path = DepthFirstTraversal(startVertex);
//           var specificPath = path.getSpecificPath(startVertex, endVertex);
//           if (specificPath != null) {
//             //specificPath.ForEach(x => Console.Write("( {0},{1} ), ", x.Item1, x.Item2));
//             specificPath.ForEach(x => Console.Write("{0}, ", x));
//             Console.WriteLine();

//           }
//         }

//         public void findBreadthPath(int startVertex, int endVertex) {
          
//           var path = BreadthFirstTraversal(startVertex);
//           var specificPath = path.getSpecificPath(startVertex, endVertex);
//           if (specificPath != null) {
//             //specificPath.ForEach(x => Console.Write("( {0},{1} ), ", x.Item1, x.Item2));
//             specificPath.ForEach(x => Console.Write("{0}, ", x));
//             Console.WriteLine();

//           }
//         }

//         public Path DepthFirstTraversal(int start) {

//           Path path = new Path();
//           for(int i = 0; i < numberOfVertices(); i++){
//             visitedVertex[i] = false;
//           }

//           //for(int j=0;j<numberOfVertices();j++){
//             //if (!visitedVertex[j]) {
//               DepthFirstSearch(start, path);
//           //  }
//          // }
//           //Console.Write(foreach x in orderTraversed);
//           //orderTraversed.ForEach(x => Console.Write("{0}, ", x));
//           return path;
//         }

//         public void DepthFirstSearch(int vertex, Path path){
//           visitedVertex[vertex] = true;
//           orderTraversed.Add(vertex);

//           for(int i=0;i<numberOfVertices();i++) {
            

//             if ((AM[vertex, i] == 1) && (!visitedVertex[i])) {
//               //Console.WriteLine("vertex: {0} i: {1} AM: {2}", vertex, i, AM[vertex, i]);
//               path.Add(vertex, i);
//               DepthFirstSearch(i, path);
//             }
//           }
//         }

//         public Path BreadthFirstTraversal(int start) {
//           for(int i = 0; i < numberOfVertices(); i++){
//             visitedVertex[i] = false;
//           }
//           Path path = new Path();
//           List<int> bfsQueue = new List<int> {start};

//           while(bfsQueue.Count>0) {
//             visitedVertex[bfsQueue[0]] = true;
//             BreadthFirstSearch(bfsQueue[0], bfsQueue, path);
//           }
//          // orderTraversed.ForEach(x => Console.Write("{0}, ", x));
//           return path;
//         }

//         public void BreadthFirstSearch(int vertex, List<int> queue, Path path){
//           for(int i =0; i<numberOfVertices(); i++){
//             if ((AM[vertex,i] == 1) && (!visitedVertex[i])){
//               queue.Add(i);
//               visitedVertex[i] = true;
//               path.Add(vertex, i);
//               //Console.WriteLine("vertex: {0}, i: {1}", vertex, i);
//             }
//           }
//           queue.RemoveAt(0);
//         }
//     }

// }