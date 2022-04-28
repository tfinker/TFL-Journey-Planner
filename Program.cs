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

            var tube = new TubeController();

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Victoria Line
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var Walthamstow         = tube.createStation( "Walthamstow Central" );
            var BlackhorseRoad      = tube.createStation( "Blackhorse Road" );
            var TottenhamHale       = tube.createStation( "Tottenham Hale" );
            var SevenSisters        = tube.createStation( "Seven Sisters" );
            var FinsburyPark        = tube.createStation( "Finsbury Park" );
            var HighburyIslington   = tube.createStation( "Highbury & Islington" );
            var KingsCross          = tube.createStation( "King's Cross" );
            var Euston              = tube.createStation( "Euston" );
            var WarrenStreet        = tube.createStation( "Warren Street" );
            var OxfordCircus        = tube.createStation( "Oxford Circus" );
            var GreenPark           = tube.createStation( "Green Park" );
            var Victoria            = tube.createStation( "Victoria" );
            var Pimlico             = tube.createStation( "Pimlico" );
            var Vauxhall            = tube.createStation( "Vauxhall" );
            var Stockwell           = tube.createStation( "Stockwell" );
            var Brixton             = tube.createStation( "Brixton" );
/*
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Jubilee Line
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var Stanmore            = tube.createStation( "Stanmore" );
            var CanonsPark          = tube.createStation( "Canons Park" );
            var Queensbury          = tube.createStation( "Queensbury" );
            var Kingsbury           = tube.createStation( "Kingsbury" );
            var WembleyPark         = tube.createStation( "Wembley Park" );
            var Neasden             = tube.createStation( "Neasden" );
            var DollisHill          = tube.createStation( "Dollis Hill" );
            var WillesdenGreen      = tube.createStation( "Willesden Green" );
            var Kilburn             = tube.createStation( "Kilburn" );
            var WestHampstead       = tube.createStation( "West Hampstead" );
            var FinchleyRoad        = tube.createStation( "Finchley Road" );
            var SwissCottage        = tube.createStation( "Swiss Cottage" );
            var StJohnsWood         = tube.createStation( "St John's Wood" );
            var BakerStreet         = tube.createStation( "Baker Street" );
            var BondStreet          = tube.createStation( "Bond Street" );
            //var GreenPark         = tube.createStation( "Green Park" );
            var Westminster         = tube.createStation( "Westminster" );
            var Waterloo            = tube.createStation( "Waterloo" );
            var Southwark           = tube.createStation( "Southwark" );
            var LondonBridge        = tube.createStation( "London Bridge" );
            var Bermondsey          = tube.createStation( "Bermondsey" );
            var CanadaWater         = tube.createStation( "Canada Water" );
            var CanaryWharf         = tube.createStation( "Canary Wharf" );
            var NorthGreenwich      = tube.createStation( "North Greenwich" );
            var CanningTown         = tube.createStation( "Canning Town" );
            var WestHam             = tube.createStation( "West Ham" );
            var Stratford           = tube.createStation( "Stratford" );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations North London Overground Line
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var Richmond            = tube.createStation( "Richmond" );
            var KewGardens            = tube.createStation( "Kew Gardens" );
            var Gunnersbury            = tube.createStation( "Gunnersbury" );
            var SouthActon            = tube.createStation( "South Acton" );
            var ActonCentral            = tube.createStation( "Acton Central" );
            var WillesdenJunction            = tube.createStation( "Willesden Junction" );
            var KensalRise            = tube.createStation( "Kensal Rise" );
            var BrondesburyPark            = tube.createStation( "Brondesbury Park" );
            var Brondesbury            = tube.createStation( "Brondesbury" );
            //var WestHampstead            = tube.createStation( "West Hampstead" );
            var FinchleyRoadFrognal            = tube.createStation( "Finchley Road & Frognal" );
            var HampsteadHeath            = tube.createStation( "Hampstead Heath" );
            var GospelOak            = tube.createStation( "Gospel Oak" );
            var KentishTownWest            = tube.createStation( "Kentish Town West" );
            var CamdenRoad            = tube.createStation( "Camden Road" );
            var CaledonianRoadBarnsbury            = tube.createStation( "Caledonian Road & Barnsbury" );
            //var HighburyIslington = tube.createStation( "Highbury & Islington" );
            var Canonbury            = tube.createStation( "Canonbury" );
            var DalstonKingsland            = tube.createStation( "Dalston Kingsland" );
            var HackneyCentral            = tube.createStation( "Hackney Central" );
            var Homerton            = tube.createStation( "Homerton" );
            var HackneyWick            = tube.createStation( "Hackney Wick" );
            //var Stratford            = tube.createStation( "Stratford" );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Circle Line
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var Stratford            = tube.createStation( "Hammersmith" );
            var Stratford            = tube.createStation( "Goldhawk Road" );
            var Stratford            = tube.createStation( "Shepherd's Bush Market" );
            var Stratford            = tube.createStation( "Wood Lane" );
            var Stratford            = tube.createStation( "White City" );
            var Stratford            = tube.createStation( "Latimer Road" );
            var Stratford            = tube.createStation( "Ladbroke Grove" );
            var Stratford            = tube.createStation( "Westbourne Park" );
            var Stratford            = tube.createStation( "Royal Oak" );
            var Stratford            = tube.createStation( "Paddington" );
            var Stratford            = tube.createStation( "Edgware Road" );
            //var Stratford            = tube.createStation( "Baker Street" );
            var Stratford            = tube.createStation( "Great Portland Street" );
            var Stratford            = tube.createStation( "Euston Square" );
            //var Stratford            = tube.createStation( "King's Cross" );
            var Stratford            = tube.createStation( "Farringdon" );
            var Stratford            = tube.createStation( "Barbican" );
            var Stratford            = tube.createStation( "Moorgate" );
            var Stratford            = tube.createStation( "Liverpool Street" );
            var Stratford            = tube.createStation( "Aldgate" );
            var Stratford            = tube.createStation( "Tower Hill" );
            var Stratford            = tube.createStation( "Monument" );
            var Stratford            = tube.createStation( "Cannon Street" );
            var Stratford            = tube.createStation( "Mansion House" );
            var Stratford            = tube.createStation( "Blackfriars" );
            var Stratford            = tube.createStation( "Temple" );
            var Stratford            = tube.createStation( "Embankment" );
            // var Stratford            = tube.createStation( "Westminster" );
            var Stratford            = tube.createStation( "St James's Park" );
            // var Stratford            = tube.createStation( "Victoria" );
            var Stratford            = tube.createStation( "Sloane Square" );
            var Stratford            = tube.createStation( "South Kensington" );
            var Stratford            = tube.createStation( "Gloucester Road" );
            var Stratford            = tube.createStation( "High Street Kensington" );
            var Stratford            = tube.createStation( "Notting Hill Gate" );
            var Stratford            = tube.createStation( "Bayswater" );
            // var Stratford            = tube.createStation( "Paddington" );
            // var Stratford            = tube.createStation( "Edgware Road" );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Piccadilly Line
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // var Stratford            = tube.createStation( "King's Cross" );
            var Stratford            = tube.createStation( "Russell Square" );
            var Stratford            = tube.createStation( "Holborn" );
            var Stratford            = tube.createStation( "Covent Garden" );
            var Stratford            = tube.createStation( "Leicester Square" );
            var Stratford            = tube.createStation( "Piccadilly Circus" );
            // var Stratford            = tube.createStation( "Green Park" );
            var Stratford            = tube.createStation( "Hyde Park Corner" );
            var Stratford            = tube.createStation( "Knightsbridge" );
            // var Stratford            = tube.createStation( "Gloucester Road" );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Central Line
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // var Stratford            = tube.createStation( "Notting Hill Gate" );
            var Stratford            = tube.createStation( "Queensway" );
            var Stratford            = tube.createStation( "Lancaster Gate" );
            var Stratford            = tube.createStation( "Marble Arch" );
            // var Stratford            = tube.createStation( "Bond Street" );
            // var Stratford            = tube.createStation( "Oxford Circus" );
            var Stratford            = tube.createStation( "Tottenham Court Road" );
            // var Stratford            = tube.createStation( "Holborn" );
            var Stratford            = tube.createStation( "Chancery Lane" );
            var Stratford            = tube.createStation( "St Paul's" );
            var Stratford            = tube.createStation( "Bank" );
            // var Stratford            = tube.createStation( "Liverpool Street" );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Bakerloo Line
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // var Stratford            = tube.createStation( "Paddington" );
            var Stratford            = tube.createStation( "Edgware Road" );
            var Stratford            = tube.createStation( "Marylebone" );
            //var Stratford            = tube.createStation( "Baker Street" );
            var Stratford            = tube.createStation( "Regent's Park" );
            // var Stratford            = tube.createStation( "Oxford Circus" );
            // var Stratford            = tube.createStation( "Piccadilly Circus" );
            var Stratford            = tube.createStation( "Charing Cross" );
            //var Stratford            = tube.createStation( "Embankment" );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Northern Line Charing Cross Branch
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // var Stratford            = tube.createStation( "Warren Street" );
            var Stratford            = tube.createStation( "Goodge Street" );
            // var Stratford            = tube.createStation( "Tottenham Court Road" );
            // var Stratford            = tube.createStation( "Leicester Square" );
            // var Stratford            = tube.createStation( "Charing Cross" );
            // var Stratford            = tube.createStation( "Embankment" );
             */
            
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Northern Line Charing Cross Branch
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  
            // var Stratford            = tube.createStation( "Moorgate" );
            // var Stratford            = tube.createStation( "Bank" );


            var VictoriaSouthbound = tube.createLine( LineName.Victoria, Direction.Southbound );

            tube.addStationToLine(VictoriaSouthbound, Walthamstow);
            tube.addStationToLine(VictoriaSouthbound, BlackhorseRoad);
            tube.addStationToLine(VictoriaSouthbound, TottenhamHale);
            // tube.addStationToLine(VictoriaSouthbound, SevenSisters);
            tube.addStationToLine(VictoriaSouthbound, FinsburyPark);
            // tube.addStationToLine(VictoriaSouthbound, HighburyIslington);

            // var VictoriaNorthbound = tube.createLine( LineName.Victoria, Direction.Northbound );
            
            // tube.addStationToLine(VictoriaNorthbound, HighburyIslington);
            // tube.addStationToLine(VictoriaNorthbound, FinsburyPark);
            // tube.addStationToLine(VictoriaNorthbound, SevenSisters);
            // tube.addStationToLine(VictoriaNorthbound, TottenhamHale);
            // tube.addStationToLine(VictoriaNorthbound, BlackhorseRoad);
            // tube.addStationToLine(VictoriaNorthbound, Walthamstow);


            
            
            tube.createConnection(VictoriaSouthbound, Walthamstow, VictoriaSouthbound, BlackhorseRoad, 1, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, BlackhorseRoad, VictoriaSouthbound, TottenhamHale, 1, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, TottenhamHale, VictoriaSouthbound, FinsburyPark, 1, ModeType.Tube);
            
       //     tube.createConnection(VictoriaNorthbound, HighburyIslington, VictoriaNorthbound, FinsburyPark, 1, ModeType.Tube);
       //     tube.createConnection(VictoriaNorthbound, FinsburyPark, VictoriaNorthbound, SevenSisters, 1, ModeType.Tube);

            tube.PrintModel();

            tube.loadWeightedGraph("Tube");

            // var path = tube.getShortestPath(Walthamstow, FinsburyPark);
            // if (path != null){
            //     tube.printPath(path);
            // }
            // tube.printGraph();

            // var closure = tube.CloseSectionOfTrack(VictoriaSouthbound, Walthamstow, BlackhorseRoad, "Leaves on track");
            
            // tube.printGraph();

            // tube.ReopenSectionOfTrack(closure);

            // tube.printGraph();

            // var delay = tube.AddDelayToLine(VictoriaSouthbound, Walthamstow, BlackhorseRoad, "Hamsters", 2);
            
            // tube.printGraph();

            // tube.ExpandDelay(delay, BlackhorseRoad, TottenhamHale, 2);

            // tube.printGraph();

            // tube.RemoveDelay(delay);

            // tube.printGraph();

        }
    }
}