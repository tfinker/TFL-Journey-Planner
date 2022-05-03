using System;

namespace LondonTube
{
    class Program
    {
        static void Main(string[] args)
        {
                        var tube = new TubeController();
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          CREATING STATIONS
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
            var KewGardens          = tube.createStation( "Kew Gardens" );
            var Gunnersbury         = tube.createStation( "Gunnersbury" );
            var SouthActon          = tube.createStation( "South Acton" );
            var ActonCentral        = tube.createStation( "Acton Central" );
            var WillesdenJunction   = tube.createStation( "Willesden Junction" );
            var KensalRise          = tube.createStation( "Kensal Rise" );
            var BrondesburyPark     = tube.createStation( "Brondesbury Park" );
            var Brondesbury         = tube.createStation( "Brondesbury" );
            //var WestHampstead     = tube.createStation( "West Hampstead" );
            var FinchleyRoadFrognal = tube.createStation( "Finchley Road & Frognal" );
            var HampsteadHeath      = tube.createStation( "Hampstead Heath" );
            var GospelOak           = tube.createStation( "Gospel Oak" );
            var KentishTownWest     = tube.createStation( "Kentish Town West" );
            var CamdenRoad          = tube.createStation( "Camden Road" );
            var CaledonianRoadBarnsbury = tube.createStation( "Caledonian Road & Barnsbury" );
            //var HighburyIslington = tube.createStation( "Highbury & Islington" );
            var Canonbury           = tube.createStation( "Canonbury" );
            var DalstonKingsland    = tube.createStation( "Dalston Kingsland" );
            var HackneyCentral      = tube.createStation( "Hackney Central" );
            var Homerton            = tube.createStation( "Homerton" );
            var HackneyWick         = tube.createStation( "Hackney Wick" );
            //var Stratford         = tube.createStation( "Stratford" );

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Circle Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var Hammersmith         = tube.createStation( "Hammersmith" );
            var GoldHawkRoad        = tube.createStation( "Goldhawk Road" );
            var ShepherdsBushMarket = tube.createStation( "Shepherd's Bush Market" );
            var WoodLane            = tube.createStation( "Wood Lane" );
            var WhiteCity           = tube.createStation( "White City" );
            var LatimerRoad         = tube.createStation( "Latimer Road" );
            var LadbrokeGrove       = tube.createStation( "Ladbroke Grove" );
            var WestbournePark      = tube.createStation( "Westbourne Park" );
            var RoyalOak            = tube.createStation( "Royal Oak" );
            var Paddington          = tube.createStation( "Paddington" );
            var EdgwareRoad         = tube.createStation( "Edgware Road" );
            //var BakerStreet       = tube.createStation( "Baker Street" );
            var GreatPortlandStreet = tube.createStation( "Great Portland Street" );
            var EustonSquare        = tube.createStation( "Euston Square" );
            //var Stratford         = tube.createStation( "King's Cross" );
            var Farringdon          = tube.createStation( "Farringdon" );
            var Barbican            = tube.createStation( "Barbican" );
            var Moorgate            = tube.createStation( "Moorgate" );
            var LiverpoolStreet     = tube.createStation( "Liverpool Street" );
            var Aldgate             = tube.createStation( "Aldgate" );
            var TowerHill           = tube.createStation( "Tower Hill" );
            var Monument            = tube.createStation( "Monument" );
            var CannonStreet        = tube.createStation( "Cannon Street" );
            var MansionHouse        = tube.createStation( "Mansion House" );
            var Blackfriars         = tube.createStation( "Blackfriars" );
            var Temple              = tube.createStation( "Temple" );
            var Embankment          = tube.createStation( "Embankment" );
            // var Westminster      = tube.createStation( "Westminster" );
            var StJamesPark         = tube.createStation( "St James's Park" );
            // var Victoria         = tube.createStation( "Victoria" );
            var SloaneSquare        = tube.createStation( "Sloane Square" );
            var SouthKensington     = tube.createStation( "South Kensington" );
            var GloucesterRoad      = tube.createStation( "Gloucester Road" );
            var HighStreetKensington = tube.createStation( "High Street Kensington" );
            var NottingHillGate     = tube.createStation( "Notting Hill Gate" );
            var Bayswater           = tube.createStation( "Bayswater" );
            // var Paddington       = tube.createStation( "Paddington" );
            // var EdgwareRoad      = tube.createStation( "Edgware Road" );

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Piccadilly Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // var KingsCross       = tube.createStation( "King's Cross" );
            var RussellSquare       = tube.createStation( "Russell Square" );
            var Holborn             = tube.createStation( "Holborn" );
            var CoventGarden        = tube.createStation( "Covent Garden" );
            var LeicesterSquare     = tube.createStation( "Leicester Square" );
            var PiccadillyCircus    = tube.createStation( "Piccadilly Circus" );
            // var GreenPark        = tube.createStation( "Green Park" );
            var HydeParkCorner      = tube.createStation( "Hyde Park Corner" );
            var Knightsbridge       = tube.createStation( "Knightsbridge" );
            // var GloucesterRoad   = tube.createStation( "Gloucester Road" );

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Central Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // var NottingHillGate  = tube.createStation( "Notting Hill Gate" );
            var Queensway           = tube.createStation( "Queensway" );
            var LancasterGate       = tube.createStation( "Lancaster Gate" );
            var MarbleArch          = tube.createStation( "Marble Arch" );
            // var BondStreet       = tube.createStation( "Bond Street" );
            // var OxfordCircus     = tube.createStation( "Oxford Circus" );
            var TottenhamCourtRoad  = tube.createStation( "Tottenham Court Road" );
            // var Holborn          = tube.createStation( "Holborn" );
            var ChanceryLane        = tube.createStation( "Chancery Lane" );
            var StPauls             = tube.createStation( "St Paul's" );
            var Bank                = tube.createStation( "Bank" );
            // var LiverpoolStreet  = tube.createStation( "Liverpool Street" );

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Bakerloo Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // var Paddington       = tube.createStation( "Paddington" );
            var EdgwareRoadBakerloo = tube.createStation( "Edgware Road" );
            var Marylebone          = tube.createStation( "Marylebone" );
            //var BakerStreet       = tube.createStation( "Baker Street" );
            var RegentsPark         = tube.createStation( "Regent's Park" );
            // var OxfordCircus     = tube.createStation( "Oxford Circus" );
            // var PiccadillyCircus = tube.createStation( "Piccadilly Circus" );
            var CharingCross        = tube.createStation( "Charing Cross" );
            //var Embankment        = tube.createStation( "Embankment" );

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Northern Line Charing Cross Branch
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // var WarrenStreet     = tube.createStation( "Warren Street" );
            var GoodgeStreet        = tube.createStation( "Goodge Street" );
            // var TottenhamCourtRoad = tube.createStation( "Tottenham Court Road" );
            // var LeicesterSquare  = tube.createStation( "Leicester Square" );
            // var CharingCross     = tube.createStation( "Charing Cross" );
            // var Embankment       = tube.createStation( "Embankment" )                                   
            // var Moorgate         = tube.createStation( "Moorgate" );
            // var Bank             = tube.createStation( "Bank" );

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          ADDING STATIONS TO LINES
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Southbound Victoria Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


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

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Northbound Victoria Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Southbound Picadilly Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
            tube.addStationToLine(PiccadillySouthbound, SouthKensington);
            tube.addStationToLine(PiccadillySouthbound, GloucesterRoad);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Northbound Picadilly Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Westbound Central Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var CentralWestbound = tube.createLine( LineName.Central, Direction.Westbound );

            tube.addStationToLine(CentralWestbound, LiverpoolStreet);
            tube.addStationToLine(CentralWestbound, Bank);
            tube.addStationToLine(CentralWestbound, StPauls);
            tube.addStationToLine(CentralWestbound, ChanceryLane);
            tube.addStationToLine(CentralWestbound, Holborn);
            tube.addStationToLine(CentralWestbound, TottenhamCourtRoad);
            tube.addStationToLine(CentralWestbound, OxfordCircus);
            tube.addStationToLine(CentralWestbound, BondStreet);
            tube.addStationToLine(CentralWestbound, MarbleArch);
            tube.addStationToLine(CentralWestbound, LancasterGate);
            tube.addStationToLine(CentralWestbound, Queensway);
            tube.addStationToLine(CentralWestbound, NottingHillGate);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Eastbound Central Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var CentralEastbound = tube.createLine( LineName.Central, Direction.Eastbound );

            tube.addStationToLine(CentralEastbound, NottingHillGate);
            tube.addStationToLine(CentralEastbound, Queensway);
            tube.addStationToLine(CentralEastbound, LancasterGate);
            tube.addStationToLine(CentralEastbound, MarbleArch);
            tube.addStationToLine(CentralEastbound, BondStreet);
            tube.addStationToLine(CentralEastbound, OxfordCircus);
            tube.addStationToLine(CentralEastbound, TottenhamCourtRoad);
            tube.addStationToLine(CentralEastbound, Holborn);
            tube.addStationToLine(CentralEastbound, ChanceryLane);
            tube.addStationToLine(CentralEastbound, StPauls);
            tube.addStationToLine(CentralEastbound, Bank);
            tube.addStationToLine(CentralEastbound, LiverpoolStreet);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Clockwise Circle Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var CircleClockwise = tube.createLine( LineName.Circle, Direction.Clockwise );

            tube.addStationToLine(CircleClockwise, Hammersmith);
            tube.addStationToLine(CircleClockwise, GoldHawkRoad);
            tube.addStationToLine(CircleClockwise, ShepherdsBushMarket);
            tube.addStationToLine(CircleClockwise, WoodLane);
            tube.addStationToLine(CircleClockwise, LatimerRoad);
            tube.addStationToLine(CircleClockwise, LadbrokeGrove);
            tube.addStationToLine(CircleClockwise, WestbournePark);
            tube.addStationToLine(CircleClockwise, RoyalOak);
            tube.addStationToLine(CircleClockwise, Paddington);
            tube.addStationToLine(CircleClockwise, EdgwareRoad);
            tube.addStationToLine(CircleClockwise, BakerStreet);
            tube.addStationToLine(CircleClockwise, GreatPortlandStreet);
            tube.addStationToLine(CircleClockwise, EustonSquare);
            tube.addStationToLine(CircleClockwise, KingsCross);
            tube.addStationToLine(CircleClockwise, Farringdon);
            tube.addStationToLine(CircleClockwise, Barbican);
            tube.addStationToLine(CircleClockwise, Moorgate);
            tube.addStationToLine(CircleClockwise, LiverpoolStreet);
            tube.addStationToLine(CircleClockwise, Aldgate);
            tube.addStationToLine(CircleClockwise, TowerHill);
            tube.addStationToLine(CircleClockwise, Monument);
            tube.addStationToLine(CircleClockwise, CannonStreet);
            tube.addStationToLine(CircleClockwise, MansionHouse);
            tube.addStationToLine(CircleClockwise, Blackfriars);
            tube.addStationToLine(CircleClockwise, Temple);
            tube.addStationToLine(CircleClockwise, Embankment);
            tube.addStationToLine(CircleClockwise, Westminster);
            tube.addStationToLine(CircleClockwise, StJamesPark);
            tube.addStationToLine(CircleClockwise, Victoria);
            tube.addStationToLine(CircleClockwise, SloaneSquare);
            tube.addStationToLine(CircleClockwise, SouthKensington);
            tube.addStationToLine(CircleClockwise, GloucesterRoad);
            tube.addStationToLine(CircleClockwise, HighStreetKensington);
            tube.addStationToLine(CircleClockwise, NottingHillGate);
            tube.addStationToLine(CircleClockwise, Bayswater);
            tube.addStationToLine(CircleClockwise, Paddington);
            tube.addStationToLine(CircleClockwise, EdgwareRoad);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Anti Clockwise Circle Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var CircleAnticlockwise = tube.createLine( LineName.Circle, Direction.Anticlockwise );

            tube.addStationToLine(CircleAnticlockwise, EdgwareRoad );
            tube.addStationToLine(CircleAnticlockwise, Paddington);
            tube.addStationToLine(CircleAnticlockwise, Bayswater);
            tube.addStationToLine(CircleAnticlockwise, NottingHillGate);
            tube.addStationToLine(CircleAnticlockwise, HighStreetKensington);
            tube.addStationToLine(CircleAnticlockwise, GloucesterRoad);
            tube.addStationToLine(CircleAnticlockwise, SouthKensington);
            tube.addStationToLine(CircleAnticlockwise, SloaneSquare);
            tube.addStationToLine(CircleAnticlockwise, Victoria);
            tube.addStationToLine(CircleAnticlockwise, StJamesPark);
            tube.addStationToLine(CircleAnticlockwise, Westminster);
            tube.addStationToLine(CircleAnticlockwise, Embankment);
            tube.addStationToLine(CircleAnticlockwise, Temple);
            tube.addStationToLine(CircleAnticlockwise, Blackfriars);
            tube.addStationToLine(CircleAnticlockwise, MansionHouse);
            tube.addStationToLine(CircleAnticlockwise, CannonStreet);
            tube.addStationToLine(CircleAnticlockwise, Monument);
            tube.addStationToLine(CircleAnticlockwise, TowerHill);
            tube.addStationToLine(CircleAnticlockwise, Aldgate);
            tube.addStationToLine(CircleAnticlockwise, LiverpoolStreet);
            tube.addStationToLine(CircleAnticlockwise, Moorgate);
            tube.addStationToLine(CircleAnticlockwise, Barbican);
            tube.addStationToLine(CircleAnticlockwise, Farringdon);
            tube.addStationToLine(CircleAnticlockwise, KingsCross);
            tube.addStationToLine(CircleAnticlockwise, EustonSquare);
            tube.addStationToLine(CircleAnticlockwise, GreatPortlandStreet);
            tube.addStationToLine(CircleAnticlockwise, BakerStreet);
            tube.addStationToLine(CircleAnticlockwise, EdgwareRoad);
            tube.addStationToLine(CircleAnticlockwise, Paddington);
            tube.addStationToLine(CircleAnticlockwise, RoyalOak );
            tube.addStationToLine(CircleAnticlockwise, WestbournePark);
            tube.addStationToLine(CircleAnticlockwise, LadbrokeGrove);
            tube.addStationToLine(CircleAnticlockwise, LatimerRoad);
            tube.addStationToLine(CircleAnticlockwise, WoodLane);
            tube.addStationToLine(CircleAnticlockwise, ShepherdsBushMarket);
            tube.addStationToLine(CircleAnticlockwise, GoldHawkRoad);
            tube.addStationToLine(CircleAnticlockwise, Hammersmith);


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Southbound Northern Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var NorthernSouthbound = tube.createLine( LineName.Northern, Direction.Southbound );

            tube.addStationToLine(NorthernSouthbound, WarrenStreet);
            tube.addStationToLine(NorthernSouthbound, GoodgeStreet);
            tube.addStationToLine(NorthernSouthbound, TottenhamCourtRoad);
            tube.addStationToLine(NorthernSouthbound, LeicesterSquare);
            tube.addStationToLine(NorthernSouthbound, CharingCross);
            tube.addStationToLine(NorthernSouthbound, Embankment);


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Northbound Northern Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var NorthernNorthbound = tube.createLine( LineName.Northern, Direction.Northbound );

            tube.addStationToLine(NorthernNorthbound, Embankment);
            tube.addStationToLine(NorthernNorthbound, CharingCross);
            tube.addStationToLine(NorthernNorthbound, LeicesterSquare);
            tube.addStationToLine(NorthernNorthbound, TottenhamCourtRoad);
            tube.addStationToLine(NorthernNorthbound, GoodgeStreet);
            tube.addStationToLine(NorthernNorthbound, WarrenStreet);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Southbound Bakerloo Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var BakerlooSouthbound = tube.createLine(LineName.Bakerloo, Direction.Southbound);

            tube.addStationToLine(BakerlooSouthbound, Paddington );
            tube.addStationToLine(BakerlooSouthbound, EdgwareRoad);
            tube.addStationToLine(BakerlooSouthbound, Marylebone);
            tube.addStationToLine(BakerlooSouthbound, BakerStreet);
            tube.addStationToLine(BakerlooSouthbound, RegentsPark);
            tube.addStationToLine(BakerlooSouthbound, OxfordCircus);
            tube.addStationToLine(BakerlooSouthbound, PiccadillyCircus);
            tube.addStationToLine(BakerlooSouthbound, CharingCross);
            tube.addStationToLine(BakerlooSouthbound, Embankment);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Northbound Bakerloo Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var BakerlooNorthbound = tube.createLine( LineName.Bakerloo, Direction.Northbound );

            tube.addStationToLine(BakerlooNorthbound, Embankment);
            tube.addStationToLine(BakerlooNorthbound, CharingCross);
            tube.addStationToLine(BakerlooNorthbound, PiccadillyCircus);
            tube.addStationToLine(BakerlooNorthbound, OxfordCircus);
            tube.addStationToLine(BakerlooNorthbound, RegentsPark);
            tube.addStationToLine(BakerlooNorthbound, BakerStreet);
            tube.addStationToLine(BakerlooNorthbound, Marylebone);
            tube.addStationToLine(BakerlooNorthbound, EdgwareRoad);
            tube.addStationToLine(BakerlooNorthbound, Paddington);


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Westbound North London Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var NorthLondonWestbound = tube.createLine( LineName.NorthLondon, Direction.Westbound );

            tube.addStationToLine(NorthLondonWestbound, Stratford);
            tube.addStationToLine(NorthLondonWestbound, HackneyWick);
            tube.addStationToLine(NorthLondonWestbound, Homerton);
            tube.addStationToLine(NorthLondonWestbound, HackneyCentral);
            tube.addStationToLine(NorthLondonWestbound, DalstonKingsland);
            tube.addStationToLine(NorthLondonWestbound, Canonbury);
            tube.addStationToLine(NorthLondonWestbound, HighburyIslington);
            tube.addStationToLine(NorthLondonWestbound, CaledonianRoadBarnsbury);
            tube.addStationToLine(NorthLondonWestbound, CamdenRoad);
            tube.addStationToLine(NorthLondonWestbound, KentishTownWest);
            tube.addStationToLine(NorthLondonWestbound, GospelOak);
            tube.addStationToLine(NorthLondonWestbound, HampsteadHeath);
            tube.addStationToLine(NorthLondonWestbound, FinchleyRoadFrognal);
            tube.addStationToLine(NorthLondonWestbound, WestHampstead);
            tube.addStationToLine(NorthLondonWestbound, BrondesburyPark);
            tube.addStationToLine(NorthLondonWestbound, KensalRise);
            tube.addStationToLine(NorthLondonWestbound, WillesdenJunction);
            tube.addStationToLine(NorthLondonWestbound, ActonCentral);
            tube.addStationToLine(NorthLondonWestbound, SouthActon);
            tube.addStationToLine(NorthLondonWestbound, Gunnersbury);
            tube.addStationToLine(NorthLondonWestbound, KewGardens);
            tube.addStationToLine(NorthLondonWestbound, Richmond);
          
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Eastbound North London Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var NorthLondonEastbound = tube.createLine( LineName.NorthLondon, Direction.Eastbound );

            tube.addStationToLine(NorthLondonEastbound, Richmond);
            tube.addStationToLine(NorthLondonEastbound, KewGardens);
            tube.addStationToLine(NorthLondonEastbound, Gunnersbury);
            tube.addStationToLine(NorthLondonEastbound, SouthActon);
            tube.addStationToLine(NorthLondonEastbound, ActonCentral);
            tube.addStationToLine(NorthLondonEastbound, WillesdenJunction);
            tube.addStationToLine(NorthLondonEastbound, KensalRise);
            tube.addStationToLine(NorthLondonEastbound, BrondesburyPark);
            tube.addStationToLine(NorthLondonEastbound, WestHampstead);
            tube.addStationToLine(NorthLondonEastbound, FinchleyRoadFrognal);
            tube.addStationToLine(NorthLondonEastbound, HampsteadHeath);
            tube.addStationToLine(NorthLondonEastbound, GospelOak);
            tube.addStationToLine(NorthLondonEastbound, KentishTownWest);
            tube.addStationToLine(NorthLondonEastbound, CamdenRoad);
            tube.addStationToLine(NorthLondonEastbound, CaledonianRoadBarnsbury);
            tube.addStationToLine(NorthLondonEastbound, HighburyIslington);
            tube.addStationToLine(NorthLondonEastbound, Canonbury);
            tube.addStationToLine(NorthLondonEastbound, DalstonKingsland);
            tube.addStationToLine(NorthLondonEastbound, HackneyCentral);
            tube.addStationToLine(NorthLondonEastbound, Homerton);
            tube.addStationToLine(NorthLondonEastbound, HackneyWick);
            tube.addStationToLine(NorthLondonEastbound, Stratford);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Eastbound Jubilee Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var JubileeEastbound = tube.createLine( LineName.Jubilee, Direction.Eastbound );

            tube.addStationToLine(JubileeEastbound, BakerStreet);
            tube.addStationToLine(JubileeEastbound, BondStreet);
            tube.addStationToLine(JubileeEastbound, GreenPark);
            tube.addStationToLine(JubileeEastbound, Westminster);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Add Stations to Westbound Jubilee Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var JubileeWestbound = tube.createLine( LineName.Jubilee, Direction.Westbound );

            tube.addStationToLine(JubileeEastbound, Westminster);
            tube.addStationToLine(JubileeEastbound, GreenPark);
            tube.addStationToLine(JubileeEastbound, BondStreet);
            tube.addStationToLine(JubileeEastbound, BakerStreet);


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          CONNECTIONS
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Southbound Victoria Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(VictoriaSouthbound, Walthamstow, VictoriaSouthbound, BlackhorseRoad, 2.1, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, BlackhorseRoad, VictoriaSouthbound, TottenhamHale, 1.9, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, TottenhamHale, VictoriaSouthbound, SevenSisters, 2.0, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, SevenSisters, VictoriaSouthbound, FinsburyPark, 3.77, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, FinsburyPark, VictoriaSouthbound, HighburyIslington, 2.90, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, HighburyIslington, VictoriaSouthbound, KingsCross, 2.77, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, KingsCross, VictoriaSouthbound, Euston, 1.32, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, Euston, VictoriaSouthbound, WarrenStreet, 1.30, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, WarrenStreet, VictoriaSouthbound, OxfordCircus, 1.72, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, OxfordCircus, VictoriaSouthbound, GreenPark, 1.78, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, GreenPark, VictoriaSouthbound, Victoria, 1.88, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, Victoria, VictoriaSouthbound, Pimlico, 1.83, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, Pimlico, VictoriaSouthbound, Vauxhall, 1.40, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, Vauxhall, VictoriaSouthbound, Stockwell, 2.30, ModeType.Tube);
            tube.createConnection(VictoriaSouthbound, Stockwell, VictoriaSouthbound, Brixton, 2.03, ModeType.Tube);


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Northbound Victoria Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(VictoriaNorthbound, Brixton, VictoriaNorthbound, Stockwell, 2.18, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, Stockwell, VictoriaNorthbound, Vauxhall, 2.23, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, Vauxhall, VictoriaNorthbound, Pimlico, 1.37, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, Pimlico, VictoriaNorthbound, Victoria, 2.18, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, Victoria, VictoriaNorthbound, GreenPark, 1.95, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, GreenPark, VictoriaNorthbound, OxfordCircus, 1.97, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, OxfordCircus, VictoriaNorthbound, WarrenStreet, 1.53, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, WarrenStreet, VictoriaNorthbound, Euston, 1.32, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, Euston, VictoriaNorthbound, KingsCross, 1.35, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, KingsCross, VictoriaNorthbound, HighburyIslington, 2.87, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, HighburyIslington, VictoriaNorthbound, FinsburyPark, 2.40, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, FinsburyPark, VictoriaNorthbound, SevenSisters, 4.25, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, SevenSisters, VictoriaNorthbound, TottenhamHale, 1.60, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, TottenhamHale, VictoriaNorthbound, BlackhorseRoad, 1.97, ModeType.Tube);
            tube.createConnection(VictoriaNorthbound, BlackhorseRoad, VictoriaNorthbound, Walthamstow, 2.12, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Southbound Picadilly Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //GS Westbound

            tube.createConnection(PiccadillySouthbound, KingsCross, PiccadillySouthbound, RussellSquare, 1.67, ModeType.Tube);
            tube.createConnection(PiccadillySouthbound, RussellSquare, PiccadillySouthbound, Holborn, 1.37, ModeType.Tube);
            tube.createConnection(PiccadillySouthbound, Holborn, PiccadillySouthbound, CoventGarden, 1.53, ModeType.Tube);
            tube.createConnection(PiccadillySouthbound, CoventGarden, PiccadillySouthbound, LeicesterSquare, 0.77, ModeType.Tube);
            tube.createConnection(PiccadillySouthbound, LeicesterSquare, PiccadillySouthbound, PiccadillyCircus, 1.07, ModeType.Tube);
            tube.createConnection(PiccadillySouthbound, PiccadillyCircus, PiccadillySouthbound, GreenPark, 1.18, ModeType.Tube);
            tube.createConnection(PiccadillySouthbound, GreenPark, PiccadillySouthbound, HydeParkCorner, 1.73, ModeType.Tube);
            tube.createConnection(PiccadillySouthbound, HydeParkCorner, PiccadillySouthbound, Knightsbridge, 1.12, ModeType.Tube);
            tube.createConnection(PiccadillySouthbound, Knightsbridge, PiccadillySouthbound, SouthKensington, 2.23, ModeType.Tube);
            tube.createConnection(PiccadillySouthbound, SouthKensington, PiccadillySouthbound, GloucesterRoad, 1.37, ModeType.Tube);


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Northbound Picadilly Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //GS Eastbound

            tube.createConnection(PiccadillyNorthbound, GloucesterRoad, PiccadillyNorthbound, SouthKensington, 1.28, ModeType.Tube);
            tube.createConnection(PiccadillyNorthbound, SouthKensington, PiccadillyNorthbound, Knightsbridge, 2.48, ModeType.Tube);
            tube.createConnection(PiccadillyNorthbound, Knightsbridge, PiccadillyNorthbound, HydeParkCorner, 1.10, ModeType.Tube);
            tube.createConnection(PiccadillyNorthbound, HydeParkCorner, PiccadillyNorthbound, GreenPark, 1.73, ModeType.Tube);
            tube.createConnection(PiccadillyNorthbound, GreenPark, PiccadillyNorthbound, PiccadillyCircus, 1.10, ModeType.Tube);
            tube.createConnection(PiccadillyNorthbound, PiccadillyCircus, PiccadillyNorthbound, LeicesterSquare, 1.17, ModeType.Tube);
            tube.createConnection(PiccadillyNorthbound, LeicesterSquare, PiccadillyNorthbound, CoventGarden, 0.77, ModeType.Tube);
            tube.createConnection(PiccadillyNorthbound, CoventGarden, PiccadillyNorthbound, Holborn, 1.40, ModeType.Tube);
            tube.createConnection(PiccadillyNorthbound, Holborn, PiccadillyNorthbound, RussellSquare, 1.55, ModeType.Tube);
            tube.createConnection(PiccadillyNorthbound, RussellSquare, PiccadillyNorthbound, KingsCross, 1.90, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Westbound Central Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(CentralWestbound, LiverpoolStreet, CentralWestbound, Bank, 1.65, ModeType.Tube);
            tube.createConnection(CentralWestbound, Bank, CentralWestbound, StPauls, 1.63, ModeType.Tube);
            tube.createConnection(CentralWestbound, StPauls, CentralWestbound, ChanceryLane, 1.52, ModeType.Tube);
            tube.createConnection(CentralWestbound, ChanceryLane, CentralWestbound, Holborn, 0.85, ModeType.Tube);
            tube.createConnection(CentralWestbound, Holborn, CentralWestbound, TottenhamCourtRoad, 1.38, ModeType.Tube);
            tube.createConnection(CentralWestbound, TottenhamCourtRoad, CentralWestbound, OxfordCircus, 1.02, ModeType.Tube);
            tube.createConnection(CentralWestbound, OxfordCircus, CentralWestbound, BondStreet, 1.03, ModeType.Tube);
            tube.createConnection(CentralWestbound, BondStreet, CentralWestbound, MarbleArch, 1.02, ModeType.Tube);
            tube.createConnection(CentralWestbound, MarbleArch, CentralWestbound, LancasterGate, 1.62, ModeType.Tube);
            tube.createConnection(CentralWestbound, LancasterGate, CentralWestbound, Queensway, 1.65, ModeType.Tube);
            tube.createConnection(CentralWestbound, Queensway, CentralWestbound, NottingHillGate, 1.18, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Eastbound Central Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(CentralEastbound, NottingHillGate, CentralEastbound, Queensway, 1.17, ModeType.Tube);
            tube.createConnection(CentralEastbound, Queensway, CentralEastbound, LancasterGate, 1.35, ModeType.Tube);
            tube.createConnection(CentralEastbound, LancasterGate, CentralEastbound, MarbleArch, 1.92, ModeType.Tube);
            tube.createConnection(CentralEastbound, MarbleArch, CentralEastbound, BondStreet, 1.00, ModeType.Tube);
            tube.createConnection(CentralEastbound, BondStreet, CentralEastbound, OxfordCircus, 1.10, ModeType.Tube);
            tube.createConnection(CentralEastbound, OxfordCircus, CentralEastbound, TottenhamCourtRoad, 0.98, ModeType.Tube);
            tube.createConnection(CentralEastbound, TottenhamCourtRoad, CentralEastbound, Holborn, 1.63, ModeType.Tube);
            tube.createConnection(CentralEastbound, Holborn, CentralEastbound, ChanceryLane, 0.87, ModeType.Tube);
            tube.createConnection(CentralEastbound, ChanceryLane, CentralEastbound, StPauls, 1.52, ModeType.Tube);
            tube.createConnection(CentralEastbound, StPauls, CentralEastbound, Bank, 1.62, ModeType.Tube);
            tube.createConnection(CentralEastbound, Bank, CentralEastbound, LiverpoolStreet, 1.62, ModeType.Tube);
            

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Clockwise Circle Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(CircleClockwise, Hammersmith, CircleClockwise, GoldHawkRoad, 2.05, ModeType.Tube);
            tube.createConnection(CircleClockwise, GoldHawkRoad, CircleClockwise, ShepherdsBushMarket, 1.15, ModeType.Tube);
            tube.createConnection(CircleClockwise, ShepherdsBushMarket, CircleClockwise, WoodLane, 1.50, ModeType.Tube);
            tube.createConnection(CircleClockwise, WoodLane, CircleClockwise, LatimerRoad, 1.50, ModeType.Tube);
            tube.createConnection(CircleClockwise, LatimerRoad, CircleClockwise, LadbrokeGrove, 1.37, ModeType.Tube);
            tube.createConnection(CircleClockwise, LadbrokeGrove, CircleClockwise, WestbournePark, 1.48, ModeType.Tube);
            tube.createConnection(CircleClockwise, WestbournePark, CircleClockwise, RoyalOak, 1.78, ModeType.Tube);
            tube.createConnection(CircleClockwise, RoyalOak, CircleClockwise, Paddington, 1.52, ModeType.Tube);
            tube.createConnection(CircleClockwise, Paddington, CircleClockwise, EdgwareRoad, 2.33, ModeType.Tube);
            tube.createConnection(CircleClockwise, EdgwareRoad, CircleClockwise, BakerStreet, 1.47, ModeType.Tube);
            tube.createConnection(CircleClockwise, BakerStreet, CircleClockwise, GreatPortlandStreet, 1.90, ModeType.Tube);
            tube.createConnection(CircleClockwise, GreatPortlandStreet, CircleClockwise, EustonSquare, 1.25, ModeType.Tube);
            tube.createConnection(CircleClockwise, EustonSquare, CircleClockwise, KingsCross, 1.75, ModeType.Tube);
            tube.createConnection(CircleClockwise, KingsCross, CircleClockwise, Farringdon, 2.98, ModeType.Tube);
            tube.createConnection(CircleClockwise, Farringdon, CircleClockwise, Barbican, 1.22, ModeType.Tube);
            tube.createConnection(CircleClockwise, Barbican, CircleClockwise, Moorgate, 1.32, ModeType.Tube);
            tube.createConnection(CircleClockwise, Moorgate, CircleClockwise, LiverpoolStreet, 1.18, ModeType.Tube);
            tube.createConnection(CircleClockwise, LiverpoolStreet, CircleClockwise, Aldgate, 2.18, ModeType.Tube);
            tube.createConnection(CircleClockwise, Aldgate, CircleClockwise, TowerHill, 1.37, ModeType.Tube);
            tube.createConnection(CircleClockwise, TowerHill, CircleClockwise, Monument, 1.48, ModeType.Tube);
            tube.createConnection(CircleClockwise, Monument, CircleClockwise, CannonStreet, 0.88, ModeType.Tube);
            tube.createConnection(CircleClockwise, CannonStreet, CircleClockwise, MansionHouse, 0.93, ModeType.Tube);
            tube.createConnection(CircleClockwise, MansionHouse, CircleClockwise, Blackfriars, 1.22, ModeType.Tube);
            tube.createConnection(CircleClockwise, Blackfriars, CircleClockwise, Temple, 1.22, ModeType.Tube);
            tube.createConnection(CircleClockwise, Temple, CircleClockwise, Embankment, 1.37, ModeType.Tube);
            tube.createConnection(CircleClockwise, Embankment, CircleClockwise, Westminster, 1.43, ModeType.Tube);
            tube.createConnection(CircleClockwise, Westminster, CircleClockwise, StJamesPark, 1.40, ModeType.Tube);
            tube.createConnection(CircleClockwise, StJamesPark, CircleClockwise, Victoria, 1.52, ModeType.Tube);
            tube.createConnection(CircleClockwise, Victoria, CircleClockwise, SloaneSquare, 1.75, ModeType.Tube);
            tube.createConnection(CircleClockwise, SloaneSquare, CircleClockwise, SouthKensington, 2.00, ModeType.Tube);
            tube.createConnection(CircleClockwise, SouthKensington, CircleClockwise, GloucesterRoad, 1.48, ModeType.Tube);
            tube.createConnection(CircleClockwise, GloucesterRoad, CircleClockwise, HighStreetKensington, 2.23, ModeType.Tube);
            tube.createConnection(CircleClockwise, HighStreetKensington, CircleClockwise, NottingHillGate, 1.68, ModeType.Tube);
            tube.createConnection(CircleClockwise, NottingHillGate, CircleClockwise, Bayswater, 1.77, ModeType.Tube);
            tube.createConnection(CircleClockwise, Bayswater, CircleClockwise, Paddington, 1.63, ModeType.Tube);
            tube.createConnection(CircleClockwise, Paddington, CircleClockwise, EdgwareRoad, 2.15, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Anti Clockwise Circle Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(CircleAnticlockwise, EdgwareRoad, CircleAnticlockwise, Paddington, 1.85, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Paddington, CircleAnticlockwise, Bayswater, 1.65, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Bayswater, CircleAnticlockwise, NottingHillGate, 1.47, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, NottingHillGate, CircleAnticlockwise, HighStreetKensington, 1.58, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, HighStreetKensington, CircleAnticlockwise, GloucesterRoad, 1.80, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, GloucesterRoad, CircleAnticlockwise, SouthKensington, 1.43, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, SouthKensington, CircleAnticlockwise, SloaneSquare, 1.98, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, SloaneSquare, CircleAnticlockwise, Victoria, 1.80, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Victoria, CircleAnticlockwise, StJamesPark, 1.42, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, StJamesPark, CircleAnticlockwise, Westminster, 1.50, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Westminster, CircleAnticlockwise, Embankment, 1.37, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Embankment, CircleAnticlockwise, Temple, 1.37, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Temple, CircleAnticlockwise, Blackfriars, 1.40, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Blackfriars, CircleAnticlockwise, MansionHouse, 1.52, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, MansionHouse, CircleAnticlockwise, CannonStreet, 0.98, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, CannonStreet, CircleAnticlockwise, Monument, 0.97, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Monument, CircleAnticlockwise, TowerHill, 1.80, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, TowerHill, CircleAnticlockwise, Aldgate, 1.30, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Aldgate, CircleAnticlockwise, LiverpoolStreet, 1.75, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, LiverpoolStreet, CircleAnticlockwise, Moorgate, 1.32, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Moorgate, CircleAnticlockwise, Barbican, 1.38, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Barbican, CircleAnticlockwise, Farringdon, 1.20, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Farringdon, CircleAnticlockwise, KingsCross, 3.12, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, KingsCross, CircleAnticlockwise, EustonSquare, 1.65, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, EustonSquare, CircleAnticlockwise, GreatPortlandStreet, 1.30, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, GreatPortlandStreet, CircleAnticlockwise, BakerStreet, 1.57, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, BakerStreet, CircleAnticlockwise, EdgwareRoad, 1.88, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, EdgwareRoad, CircleAnticlockwise, Paddington, 2.08, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, Paddington, CircleAnticlockwise, RoyalOak, 1.33, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, RoyalOak, CircleAnticlockwise, WestbournePark, 1.72, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, WestbournePark, CircleAnticlockwise, LadbrokeGrove, 1.48, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, LadbrokeGrove, CircleAnticlockwise, LatimerRoad, 1.28, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, LatimerRoad, CircleAnticlockwise, WoodLane, 1.50, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, WoodLane, CircleAnticlockwise, ShepherdsBushMarket, 1.50, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, ShepherdsBushMarket, CircleAnticlockwise, GoldHawkRoad, 1.15, ModeType.Tube);
            tube.createConnection(CircleAnticlockwise, GoldHawkRoad, CircleAnticlockwise, Hammersmith, 2.43, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Southbound Northern Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(NorthernSouthbound, WarrenStreet, NorthernSouthbound, GoodgeStreet, 1.07, ModeType.Tube);
            tube.createConnection(NorthernSouthbound, GoodgeStreet, NorthernSouthbound, TottenhamCourtRoad, 1.32, ModeType.Tube);
            tube.createConnection(NorthernSouthbound, TottenhamCourtRoad, NorthernSouthbound, LeicesterSquare, 0.98, ModeType.Tube);
            tube.createConnection(NorthernSouthbound, LeicesterSquare, NorthernSouthbound, CharingCross, 1.20, ModeType.Tube);
            tube.createConnection(NorthernSouthbound, CharingCross, NorthernSouthbound, Embankment, 0.80, ModeType.Tube);
            tube.createConnection(NorthernSouthbound, Embankment, NorthernSouthbound, Waterloo, 1.37, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //           Stations Northbound Northern Line
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(NorthernNorthbound, Waterloo, NorthernNorthbound, Embankment, 1.40, ModeType.Tube);
            tube.createConnection(NorthernNorthbound, Embankment, NorthernNorthbound, CharingCross, 0.87, ModeType.Tube);
            tube.createConnection(NorthernNorthbound, CharingCross, NorthernNorthbound, LeicesterSquare, 1.17, ModeType.Tube);
            tube.createConnection(NorthernNorthbound, LeicesterSquare, NorthernNorthbound, TottenhamCourtRoad, 1.03, ModeType.Tube);
            tube.createConnection(NorthernNorthbound, TottenhamCourtRoad, NorthernNorthbound, GoodgeStreet, 1.28, ModeType.Tube);
            tube.createConnection(NorthernNorthbound, GoodgeStreet, NorthernNorthbound, WarrenStreet, 1.07, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Southbound Bakerloo Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(BakerlooSouthbound, Paddington, BakerlooSouthbound, EdgwareRoad, 1.57, ModeType.Tube);
            tube.createConnection(BakerlooSouthbound, EdgwareRoad, BakerlooSouthbound, Marylebone, 1.12, ModeType.Tube);
            tube.createConnection(BakerlooSouthbound, Marylebone, BakerlooSouthbound, BakerStreet, 1.17, ModeType.Tube);
            tube.createConnection(BakerlooSouthbound, BakerStreet, BakerlooSouthbound, RegentsPark, 1.68, ModeType.Tube);
            tube.createConnection(BakerlooSouthbound, RegentsPark, BakerlooSouthbound, OxfordCircus, 1.85, ModeType.Tube);
            tube.createConnection(BakerlooSouthbound, OxfordCircus, BakerlooSouthbound, PiccadillyCircus, 1.95, ModeType.Tube);
            tube.createConnection(BakerlooSouthbound, PiccadillyCircus, BakerlooSouthbound, CharingCross, 0.95, ModeType.Tube);
            tube.createConnection(BakerlooSouthbound, CharingCross, BakerlooSouthbound, Embankment, 1.43, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Northbound Bakerloo Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(BakerlooNorthbound, Embankment, BakerlooNorthbound, CharingCross, 0.97, ModeType.Tube);
            tube.createConnection(BakerlooNorthbound, CharingCross, BakerlooNorthbound, PiccadillyCircus, 1.60, ModeType.Tube);
            tube.createConnection(BakerlooNorthbound, PiccadillyCircus, BakerlooNorthbound, OxfordCircus, 2.02, ModeType.Tube);
            tube.createConnection(BakerlooNorthbound, OxfordCircus, BakerlooNorthbound, RegentsPark, 1.72, ModeType.Tube);
            tube.createConnection(BakerlooNorthbound, RegentsPark, BakerlooNorthbound, BakerStreet, 1.65, ModeType.Tube);
            tube.createConnection(BakerlooNorthbound, BakerStreet, BakerlooNorthbound, Marylebone, 1.08, ModeType.Tube);
            tube.createConnection(BakerlooNorthbound, Marylebone, BakerlooNorthbound, EdgwareRoad, 1.08, ModeType.Tube);
            tube.createConnection(BakerlooNorthbound, EdgwareRoad, BakerlooNorthbound, Paddington, 1.62, ModeType.Tube);


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Eastbound North London Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            tube.createConnection(NorthLondonEastbound, Richmond, NorthLondonEastbound, KewGardens, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, KewGardens, NorthLondonEastbound, Gunnersbury, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, Gunnersbury, NorthLondonEastbound, SouthActon, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, SouthActon, NorthLondonEastbound, ActonCentral, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, ActonCentral, NorthLondonEastbound, WillesdenJunction, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, WillesdenJunction, NorthLondonEastbound, KensalRise, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, KensalRise, NorthLondonEastbound, BrondesburyPark, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, BrondesburyPark, NorthLondonEastbound, Brondesbury, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, Brondesbury, NorthLondonEastbound, WestHampstead, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, WestHampstead, NorthLondonEastbound, FinchleyRoadFrognal, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, FinchleyRoadFrognal, NorthLondonEastbound, HampsteadHeath, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, HampsteadHeath, NorthLondonEastbound, GospelOak, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, GospelOak, NorthLondonEastbound, KentishTownWest, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, KentishTownWest, NorthLondonEastbound, CamdenRoad, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, CamdenRoad, NorthLondonEastbound, CaledonianRoadBarnsbury, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, CaledonianRoadBarnsbury, NorthLondonEastbound, HighburyIslington, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, HighburyIslington, NorthLondonEastbound, Canonbury, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, Canonbury, NorthLondonEastbound, DalstonKingsland, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, DalstonKingsland, NorthLondonEastbound, HackneyCentral, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, HackneyCentral, NorthLondonEastbound, Homerton, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, Homerton, NorthLondonEastbound, HackneyWick, 1, ModeType.Tube);
            tube.createConnection(NorthLondonEastbound, HackneyWick, NorthLondonEastbound, Stratford, 1, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Westbound North London Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(NorthLondonWestbound, Stratford, NorthLondonWestbound, HackneyWick, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, HackneyWick, NorthLondonWestbound, Homerton, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, Homerton, NorthLondonWestbound, HackneyCentral, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, HackneyCentral, NorthLondonWestbound, DalstonKingsland, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, DalstonKingsland, NorthLondonWestbound, Canonbury, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, Canonbury, NorthLondonWestbound, HighburyIslington, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, HighburyIslington, NorthLondonWestbound, CaledonianRoadBarnsbury, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, CaledonianRoadBarnsbury, NorthLondonWestbound, CamdenRoad, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, CamdenRoad, NorthLondonWestbound, KentishTownWest, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, KentishTownWest, NorthLondonWestbound, GospelOak, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, GospelOak, NorthLondonWestbound, HampsteadHeath, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, HampsteadHeath, NorthLondonWestbound, FinchleyRoadFrognal, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, FinchleyRoadFrognal, FinchleyRoadFrognal, WestHampstead, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, WestHampstead, NorthLondonWestbound, Brondesbury, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, Brondesbury, NorthLondonWestbound, BrondesburyPark, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, BrondesburyPark, NorthLondonWestbound, KensalRise, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, KensalRise, NorthLondonWestbound, WillesdenJunction, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, WillesdenJunction, NorthLondonWestbound, ActonCentral, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, ActonCentral, NorthLondonWestbound, SouthActon, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, SouthActon, NorthLondonWestbound, Gunnersbury, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, Gunnersbury, NorthLondonWestbound, KewGardens, 1, ModeType.Tube);
            tube.createConnection(NorthLondonWestbound, KewGardens, NorthLondonWestbound, Richmond, 1, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Eastbound Jubilee Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            
            tube.createConnection(JubileeEastbound, BondStreet, JubileeEastbound, GreenPark, 1.78, ModeType.Tube);
            tube.createConnection(JubileeEastbound, GreenPark, JubileeEastbound, Westminster, 1.87, ModeType.Tube);
            tube.createConnection(JubileeEastbound, Westminster, JubileeEastbound, Waterloo, 1.38, ModeType.Tube);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //          Stations Westbound Jubilee Line Connections
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            tube.createConnection(JubileeWestbound, Waterloo, JubileeWestbound, Westminster, 1.43, ModeType.Tube);
            tube.createConnection(JubileeWestbound, Westminster, JubileeWestbound, GreenPark, 1.82, ModeType.Tube);
            tube.createConnection(JubileeWestbound, GreenPark, JubileeWestbound, BondStreet, 1.82, ModeType.Tube);
            tube.createConnection(JubileeWestbound, BondStreet, JubileeWestbound, BakerStreet, 2.28, ModeType.Tube);

            // TO DO : Add in interchanges and add in lines which intersect other lines
            // CONFIRM TIMES ON NORTH OVERGROUND LINE

            tube.PrintModel();

            tube.loadWeightedGraph("Tube");

            var path = tube.getShortestPath(Walthamstow, FinsburyPark);
            if (path != null){
                tube.printPath(path);
            }
            tube.printGraph();

            var closure = tube.CloseSectionOfTrack(VictoriaSouthbound, Walthamstow, BlackhorseRoad, "Leaves on track");
            
            tube.printGraph();

            tube.ReopenSectionOfTrack(closure);

            tube.printGraph();

            var delay = tube.AddDelayToLine(VictoriaSouthbound, Walthamstow, BlackhorseRoad, "Hamsters", 2);
            
            tube.printGraph();

            tube.ExpandDelay(delay, BlackhorseRoad, TottenhamHale, 2);

            tube.printGraph();

            tube.RemoveDelay(delay);

            // tube.printGraph();

        }
    }
}

