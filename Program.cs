using System;

namespace Tutorial_9
{
    class TestingGraphs
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("/////////////////////////////////////////////////");
            // Console.WriteLine("//              Testing Graphs                 //") ;
            // Console.WriteLine("/////////////////////////////////////////////////");
            // Console.WriteLine();

            // const String name             = "Week 9 Graph";
            // const int    numberOfVertices = 8 ;

            // // int[,] Edges = new int[,] { { 0, 1 }, { 0, 2 }, { 0, 3 },
            // //                             { 1, 0 }, { 1, 2 }, { 1, 3 }, { 1, 5}, 
            // //                             { 2, 1 }, { 2, 5 }, { 2, 6 }, 
            // //                             { 3, 0 }, { 3, 1 }, { 3, 7 },  
            // //                             { 4, 2 }, 
            // //                             //{ 5, 6 }, { 5, 7 },
            // //                             { 6, 2, }, { 6, 4}
            // //                           } ;
            // int[,] Edges = new int[,] { { 0, 3, 6 }, { 0, 4, 4 }, // A 0
            //                             { 1, 0, 1 }, { 1, 2, 8 },  // B 1
            //                             // C 2
            //                             { 3, 1, 3 }, { 3, 5, 3 },   // D 3
            //                             { 4, 2, 1 }, { 4, 7, 9 }, // E 4
            //                             { 5, 6, 8 },  // F 5
            //                             { 6, 2, 1 },  // G 6 
            //                             { 7, 5, 5 }, { 7, 6, 5 },// H 7
            //                           } ;




            // // Console.WriteLine("/////////////////////////////////////////////////////");
            // // Console.WriteLine("// Create Undirected Graph using Adjacency Matrix  //");
            // // Console.WriteLine("/////////////////////////////////////////////////////");
            // // Console.WriteLine();

            // // TO DO:  
            // // Create the graph 

            // // var graph = new GraphAdjMatrix(name, numberOfVertices, Edges);
            // // graph.Print();

            // var graph = new GraphAdjListWeighted(name, numberOfVertices, Edges);
            // graph.Print();
            
            // var sp = new ShortestPath(graph);
            // sp.getShortestPaths(0);

            // Console.WriteLine();
            // Console.WriteLine("/////////////////////////////////////////////////");
            // Console.WriteLine("//    Test Undirected Graph methods            //");
            // Console.WriteLine("/////////////////////////////////////////////////");
            // Console.WriteLine();

            // // TO DO:  
            // // Test its methods 


            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("//////////////////////////////////////////////////");
            // Console.WriteLine("// Create Undirected Graph using Adjacency List //");
            // Console.WriteLine("//////////////////////////////////////////////////");
            // Console.WriteLine();

            // // TO DO:  
            // // Create the graph 

            // Console.WriteLine();
            // Console.WriteLine("/////////////////////////////////////////////////");
            // Console.WriteLine("//    Test Graph methods                       //");
            // Console.WriteLine("/////////////////////////////////////////////////");
            // Console.WriteLine();

            // TO DO:  
            // Test its methods          


           // var graph = new GraphAdjMatrixTraversal(name, numberOfVertices, Edges);
            //graph.DepthFirstTraversal(6);

            //graph.findDepthPath(7,0);
            //graph.findBreadthPath(7,0);

            //var list = new VertexLink[3];

            var model = new TubeModel();

            var (VictoriaSouthbound, FinsburyPark) = model.addLine(new Line(LineNames.Victoria, Direction.Southbound, new Station("Finsbury Park")));
            //model.addLine(new Line(LineNames.Victoria, Direction.Northbound));
            var HighburyIslington = model.addStationToLine(VictoriaSouthbound, new Station("Highbury & Islington"), 3);

            
        }
    }
}