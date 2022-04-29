using System;

namespace LondonTube
{
    class Program
    {
        static void Main(string[] args)
        {
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

            var Hammersmith            = tube.createStation( "Hammersmith" );
            var GoldHawkRoad            = tube.createStation( "Goldhawk Road" );
            var ShepherdsBushMarket            = tube.createStation( "Shepherd's Bush Market" );
            var WoodLane            = tube.createStation( "Wood Lane" );
            var WhiteCity            = tube.createStation( "White City" );
            var LatimerRoad            = tube.createStation( "Latimer Road" );
            var LadbrokeGrove            = tube.createStation( "Ladbroke Grove" );
            var WestbournePark            = tube.createStation( "Westbourne Park" );
            var RoyalOak            = tube.createStation( "Royal Oak" );
            var Paddington            = tube.createStation( "Paddington" );
            var EdgwareRoad            = tube.createStation( "Edgware Road" );
            //var BakerStreet            = tube.createStation( "Baker Street" );
            var GreatPortlandStreet            = tube.createStation( "Great Portland Street" );
            var EustonSquare            = tube.createStation( "Euston Square" );
            //var Stratford            = tube.createStation( "King's Cross" );
            var Farringdon            = tube.createStation( "Farringdon" );
            var Barbican            = tube.createStation( "Barbican" );
            var Moorgate            = tube.createStation( "Moorgate" );
            var LiverpoolStreet            = tube.createStation( "Liverpool Street" );
            var Aldgate            = tube.createStation( "Aldgate" );
            var TowerHill            = tube.createStation( "Tower Hill" );
            var Monument            = tube.createStation( "Monument" );
            var CannonStreet            = tube.createStation( "Cannon Street" );
            var MansionHouse            = tube.createStation( "Mansion House" );
            var Blackfriars            = tube.createStation( "Blackfriars" );
            var Temple            = tube.createStation( "Temple" );
            var Embankment            = tube.createStation( "Embankment" );
            // var Westminster            = tube.createStation( "Westminster" );
            var StJamesPark            = tube.createStation( "St James's Park" );
            // var Victoria            = tube.createStation( "Victoria" );
            var SloaneSquare            = tube.createStation( "Sloane Square" );
            var SouthKensington            = tube.createStation( "South Kensington" );
            var GloucesterRoad            = tube.createStation( "Gloucester Road" );
            var HighStreetKensington            = tube.createStation( "High Street Kensington" );
            var NottingHillGate            = tube.createStation( "Notting Hill Gate" );
            var Bayswater            = tube.createStation( "Bayswater" );
            // var Paddington            = tube.createStation( "Paddington" );
            // var EdgwareRoad            = tube.createStation( "Edgware Road" );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Piccadilly Line
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // var KingsCross            = tube.createStation( "King's Cross" );
            var RussellSquare            = tube.createStation( "Russell Square" );
            var Holborn            = tube.createStation( "Holborn" );
            var CoventGarden            = tube.createStation( "Covent Garden" );
            var LeicesterSquare            = tube.createStation( "Leicester Square" );
            var PiccadillyCircus            = tube.createStation( "Piccadilly Circus" );
            // var GreenPark            = tube.createStation( "Green Park" );
            var HydeParkCorner            = tube.createStation( "Hyde Park Corner" );
            var Knightsbridge            = tube.createStation( "Knightsbridge" );
            // var GloucesterRoad            = tube.createStation( "Gloucester Road" );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Central Line
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // var NottingHillGate            = tube.createStation( "Notting Hill Gate" );
            var Queensway            = tube.createStation( "Queensway" );
            var LancasterGate            = tube.createStation( "Lancaster Gate" );
            var MarbleArch            = tube.createStation( "Marble Arch" );
            // var BondStreet            = tube.createStation( "Bond Street" );
            // var OxfordCircus            = tube.createStation( "Oxford Circus" );
            var TottenhamCourtRoad            = tube.createStation( "Tottenham Court Road" );
            // var Holborn            = tube.createStation( "Holborn" );
            var ChanceryLane            = tube.createStation( "Chancery Lane" );
            var StPauls            = tube.createStation( "St Paul's" );
            var Bank            = tube.createStation( "Bank" );
            // var LiverpoolStreet            = tube.createStation( "Liverpool Street" );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Bakerloo Line
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // var Paddington            = tube.createStation( "Paddington" );
            var EdgwareRoadBakerloo            = tube.createStation( "Edgware Road" );
            var Marylebone            = tube.createStation( "Marylebone" );
            //var Stratford            = tube.createStation( "Baker Street" );
            var RegentsPark            = tube.createStation( "Regent's Park" );
            // var Stratford            = tube.createStation( "Oxford Circus" );
            // var Stratford            = tube.createStation( "Piccadilly Circus" );
            var CharingCross            = tube.createStation( "Charing Cross" );
            //var Stratford            = tube.createStation( "Embankment" );

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Northern Line Charing Cross Branch
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // var Stratford            = tube.createStation( "Warren Street" );
            var GoodgeStreet            = tube.createStation( "Goodge Street" );
            // var Stratford            = tube.createStation( "Tottenham Court Road" );
            // var Stratford            = tube.createStation( "Leicester Square" );
            // var Stratford            = tube.createStation( "Charing Cross" );
            // var Stratford            = tube.createStation( "Embankment" );
             
            
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//          Stations Northern Line Charing Cross Branch
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  
            // var Stratford            = tube.createStation( "Moorgate" );
            // var Stratford            = tube.createStation( "Bank" );


            var VictoriaSouthbound = tube.createLine( LineName.Victoria, Direction.Southbound );

            tube.addStationToLine(VictoriaSouthbound, Walthamstow);
            tube.addStationToLine(VictoriaSouthbound, BlackhorseRoad);
            tube.addStationToLine(VictoriaSouthbound, TottenhamHale);
            tube.addStationToLine(VictoriaSouthbound, SevenSisters);
            tube.addStationToLine(VictoriaSouthbound, FinsburyPark);
            tube.addStationToLine(VictoriaSouthbound, HighburyIslington);
            tube.addStationToLine(VictoriaSouthbound, KingsCross);
            tube.addStationToLine(VictoriaSouthbound, Euston);
            tube.addStationToLine(VictoriaSouthbound, WarrenStreet);
            tube.addStationToLine(VictoriaSouthbound, OxfordCircus);
            tube.addStationToLine(VictoriaSouthbound, GreenPark);
            tube.addStationToLine(VictoriaSouthbound, Victoria);
            tube.addStationToLine(VictoriaSouthbound, Pimlico);
            tube.addStationToLine(VictoriaSouthbound, Vauxhall);
            tube.addStationToLine(VictoriaSouthbound, Stockwell);
            tube.addStationToLine(VictoriaSouthbound, Brixton);

            var VictoriaNorthbound = tube.createLine( LineName.Victoria, Direction.Northbound );

            tube.addStationToLine(VictoriaNorthbound, Brixton);
            tube.addStationToLine(VictoriaNorthbound, Stockwell);
            tube.addStationToLine(VictoriaNorthbound, Vauxhall);
            tube.addStationToLine(VictoriaNorthbound, Pimlico);
            tube.addStationToLine(VictoriaNorthbound, Victoria);
            tube.addStationToLine(VictoriaNorthbound, GreenPark);
            tube.addStationToLine(VictoriaNorthbound, OxfordCircus);
            tube.addStationToLine(VictoriaNorthbound, WarrenStreet);
            tube.addStationToLine(VictoriaNorthbound, Euston);
            tube.addStationToLine(VictoriaNorthbound, KingsCross);
            tube.addStationToLine(VictoriaNorthbound, HighburyIslington);
            tube.addStationToLine(VictoriaNorthbound, FinsburyPark);
            tube.addStationToLine(VictoriaNorthbound, SevenSisters);
            tube.addStationToLine(VictoriaNorthbound, TottenhamHale);
            tube.addStationToLine(VictoriaNorthbound, BlackhorseRoad);
            tube.addStationToLine(VictoriaNorthbound, Walthamstow);
            
            
            var PiccadillySouthbound = tube.createLine( LineName.Piccadilly, Direction.Southbound );

            tube.addStationToLine(PiccadillySouthbound, KingsCross);
            tube.addStationToLine(PiccadillySouthbound, RussellSquare);
            tube.addStationToLine(PiccadillySouthbound, Holborn);
            tube.addStationToLine(PiccadillySouthbound, CoventGarden);
            tube.addStationToLine(PiccadillySouthbound, LeicesterSquare);
            tube.addStationToLine(PiccadillySouthbound, PiccadillyCircus);
            tube.addStationToLine(PiccadillySouthbound, GreenPark);
            tube.addStationToLine(PiccadillySouthbound, HydeParkCorner);
            tube.addStationToLine(PiccadillySouthbound, Knightsbridge);
            tube.addStationToLine(PiccadillySouthbound, GloucesterRoad);

            var PiccadillyNorthbound = tube.createLine( LineName.Piccadilly, Direction.Northbound );


            tube.addStationToLine(PiccadillyNorthbound, GloucesterRoad);
            tube.addStationToLine(PiccadillyNorthbound, Knightsbridge);
            tube.addStationToLine(PiccadillyNorthbound, HydeParkCorner);
            tube.addStationToLine(PiccadillyNorthbound, GreenPark);
            tube.addStationToLine(PiccadillyNorthbound, PiccadillyCircus);
            tube.addStationToLine(PiccadillyNorthbound, LeicesterSquare);
            tube.addStationToLine(PiccadillyNorthbound, CoventGarden);
            tube.addStationToLine(PiccadillyNorthbound, Holborn);
            tube.addStationToLine(PiccadillyNorthbound, RussellSquare);
            tube.addStationToLine(PiccadillyNorthbound, KingsCross);

            
            var CentralWestbound = tube.createLine( LineName.Central, Direction.Westbound );
            var CentralEastbound = tube.createLine( LineName.Central, Direction.Eastbound );
            var CircleClockwise = tube.createLine( LineName.Circle, Direction.Clockwise );
            var CircleAnticlockwise = tube.createLine( LineName.Circle, Direction.Anticlockwise );
            var NorthernSouthbound = tube.createLine( LineName.Northern, Direction.Southbound );
            var NorthernNorthbound = tube.createLine( LineName.Northern, Direction.Northbound );
            var BakerlooNorthbound = tube.createLine( LineName.Bakerloo, Direction.Northbound );
            var BakerlooSouthbound = tube.createLine( LineName.Bakerloo, Direction.Southbound );
            var NorthLondonWestbound = tube.createLine( LineName.NorthLondon, Direction.Westbound );
            var NorthLondonEastbound = tube.createLine( LineName.NorthLondon, Direction.Eastbound );
            var JubileeEastbound = tube.createLine( LineName.Jubilee, Direction.Eastbound );
            var JubileeWestbound = tube.createLine( LineName.Jubilee, Direction.Westbound );

            
            
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

// make cw ready
// file neames , class names etc
// 
// linkedlist enumerator
// 