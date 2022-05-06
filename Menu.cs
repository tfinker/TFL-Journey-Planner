using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LondonTube
{

    class Menu
    {

        private TubeController _tbc;
        public Menu(TubeController tbc)
        {
            _tbc = tbc;
        }

        public void mainMenu()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to the TFL Rail Planner Application");
                Console.WriteLine(" - Press (1) to Enter the Engineers Menu");
                Console.WriteLine(" - Press (2) to Enter the Customer Menu");
                Console.Write("Please enter an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        engineersMenu();
                        break;
                    case "2":
                        customerMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please enter an option 1 or 2");
                        break;
                }
            }
        }

        public void engineersMenu()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to the Engineers Menu");
                Console.WriteLine(" - Press (1) to Add Delay to a Line");
                Console.WriteLine(" - Press (2) to Remove Delay from a Line");
                Console.WriteLine(" - Press (3) to Close a Track Section");
                Console.WriteLine(" - Press (4) to Open a Track Section");
                Console.WriteLine(" - Press (5) to Show Closed Track Sections");
                Console.WriteLine(" - Press (6) to Show Delayed Track Sections");
                Console.WriteLine(" - Press (7) to Return to Main Menu");
                Console.Write("Please enter an option: ");
                switch (Console.ReadLine())
                {

                    case "1":
                        AddDelayMenu();
                        break;
                    case "2":
                        RemoveDelayMenu();
                        break;
                    case "3":
                        CloseSectionOfTrack();
                        break;
                    case "4":
                        ReopenSectionOfTrack();
                        break;
                    case "5":
                        //listClosures();
                        break;
                    case "6":
                        //listDelays();
                        break;
                    case "7":
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please enter an option from 1 to 7");
                        break;
                }
            }
        }

        //Add delay

        //NOTE*** I need to change the ExpandDelay and AddDelayToLine functions slightly before you do this.
        //this is broken up in two parts, creating a delay and expanding a delay

        public Line AddDelayMenu()

        //CREATING

        {
            //1) Get the lines list from tube controller

            Console.WriteLine();

            Console.WriteLine("Add Delay");

            var id = _tbc.getLines();
            int index = 1;
            foreach (Line line in id)
            {
                Console.WriteLine("{0} - {1}", index++, line.ToString());
            }

            //2) ask user which line to apply delay

            while (true)
            {
                try
                {
                    Console.WriteLine("Please select the Line to add a Delay");
                    return id[Convert.ToInt32(Console.ReadLine())];
                }
                catch
                {
                    Console.WriteLine("Incorrect option, please try again");
                }
            }
        }

        //3) Get stations list from that line object

        //4) Ask user which station the delay starts at(we can only create a delay between stations that are next to each other)

        //5) Ask the delay time

        //6) Ask the delay reason

        //7) Submit the delay to AddDelayToLine(Line line, Station source, Station target, String reason, Double time)

        // Target must be the next station on the line(this is actually a bit obsolete sicne hte user doesn't select this, I might remove the target argument)

        //EXPANDING

        //8) Display the next station and Ask the user if they wnat to expand the delay using the trackDelay object that was returned

        //9) Ask for a delay time

        //10) Submit to TubeController.ExpandDelay(TrackDelay trackDelay, Double time)

        //11) repeat 8-10 until they dont want to expand

        ////Remove Delay

        public TrackDelay RemoveDelayMenu()
        {

            //1) Get delays from TubeController.Delays

            Console.WriteLine();
            Console.WriteLine("Remove Delays");

            var id = _tbc.getDelays();
            int index = 1;
            foreach (TrackDelay line in id)
            {
                Console.WriteLine("{0} - {1}", index++, line.ToString());
            }

            //    2) ask user which delay they want to remove

            while (true)
            {
                try
                {
                    Console.WriteLine("Please select the Delay you would like to remove");
                    return id[Convert.ToInt32(Console.ReadLine())];
                }
                catch
                {
                    Console.WriteLine("Incorrect option, please try again");
                }
            }
        }

        //                Console.WriteLine("Are you sure tou want to this delay? (Y/N): ");
        //                switch (Console.ReadLine())
        //                {
        //                    case "Y":
        //                        return;
        //                    case "N":
        //                        return;
        //                    default:
        //                        Console.WriteLine("Wrong value entered, please try again");
        //                        break;
        //                }

        //3) Use RemoveDelay(TrackDelay trackDelay)

        //Close Section of track

        public Line CloseSectionOfTrack()
        {

            //    1) Get the lines list from tube controller


            Console.WriteLine();

            Console.WriteLine("Line Clousures");

            var id = _tbc.getLines();
            int index = 1;
            foreach (Line line in id)
            {
                Console.WriteLine("{0} - {1}", index++, line.ToString());
            }

            //    2) Ask user which line they want to close

            while (true)
            {
                try
                {
                    Console.WriteLine("Please select the Line to add a Closure");
                    return id[Convert.ToInt32(Console.ReadLine())];
                }
                catch
                {
                    Console.WriteLine("Incorrect option, please try again");
                }
            }
        }


        //                Console.WriteLine("Are you sure tou want to make a closure on this line? (Y/N): ");
        //                switch (Console.ReadLine())
        //                {
        //                    case "Y":
        //                        return;
        //                    case "N":
        //                        return;
        //                    default:
        //                        Console.WriteLine("Wrong value entered, please try again");
        //                        break;
        //                }


        //    3) Get stations list form that line object

        //    4) Ask user which station the closure starts at




        //                Console.WriteLine("Please enter starting station");
        //                Console.ReadLine();


        //                        Console.WriteLine("Is this the correct starting station? (Y/N): ");
        //                        
        //                        {
        //                            case "Y":
        //                                return;
        //                            case "N":
        //                                return;
        //                            default:
        //                                Console.WriteLine("Wrong value entered, please try again");
        //                                break;
        //                        }


        //    5) Ask user which station the closure ends at

        //                    Console.WriteLine("Please enter end station");
        //                    Console.ReadLine();

        //                            Console.WriteLine("Is this the correct end station? (Y/N): ");
        //                            switch (Console.ReadLine())
        //                            {
        //                                case "Y":
        //                                    return;
        //                                case "N":
        //                                    return;
        //                                default:
        //                                    Console.WriteLine("Wrong value entered, please try again");
        //                                    break;
        //                            }


        //    6) Ask for a reason

        //        private string getNote()
        //        {
        //            Console.WriteLine("Please enter a note: (Press enter to leave blank)");
        //            string note = Console.ReadLine();
        //            return note;
        //        }



        //    7) Submit to CloseSectionOfTrack(Line line, Station source, Station target, String reason)

        //Reopen section of track


        public TrackClosure ReopenSectionOfTrack()

        {
            //    1) Get the closures from TubeController.closures

            Console.WriteLine();

            Console.WriteLine("Line Clousures");

            var id = _tbc.getClosures();
            int index = 1;
            foreach (TrackClosure closure in id)
            {
                Console.WriteLine("{0} - {1}", index++, closure.ToString());
            }

            //    2) ask user which closure to reopen

            while (true)
            {
                try
                {
                    Console.WriteLine("Please select a Closure you would like to remove");
                    return id[Convert.ToInt32(Console.ReadLine())];
                }
                catch
                {
                    Console.WriteLine("Incorrect option, please try again");
                }

            }
        }

        //    3) Submit closure to ReopenSectionOfTrack(TrackClosure closure)

        //            public void listClosures()

        //            {
        //                Console.WriteLine("Closure List");

        //                if (elements.Count == 0)

        //                {
        //                    Console.WriteLine("No current track closures");
        //                }

        //                foreach (TrackClosure tc in elements)
        //                {
        //                    Console.WriteLine(tc);
        //                }
        //            }

        //            public void listDelays()
        //            {
        //                Console.WriteLine("List Closures");

        //                if (delays.Count == 0)

        //                {
        //                    Console.WriteLine("No current delays");
        //                }

        //                foreach (TrackClosure tc in delays)
        //                {
        //                    Console.WriteLine(tc);
        //                }
        //            }

        public void customerMenu()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to Customer Journey Planner Menu");
                Console.WriteLine(" - Press (1) to find Fastest Route");
                Console.WriteLine(" - Press (2) to display Station Information");
                Console.WriteLine(" - Press (3) to Return to Main Menu");
                Console.WriteLine("Please enter an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        findFastestRoute();
                        break;
                    case "2":
                        displayStationInfo();
                        break;
                    case "3":
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please enter an option from 1 to 3");
                        break;
                }
            }
        }

        //Find fastest route we are going to give user ability to select a start station and end station


        private void findFastestRoute()
        {
            //1) Get stations list from tube controller

            Console.WriteLine();

            Console.WriteLine("Find Fastest Route");

            var id = _tbc.getStations();
            int index = 1;

            foreach (Station station in id)
            {
                Console.WriteLine("{0} - {1}", index++, station.ToString());
            }


        }

        //2) Ask user which station they want to start from the stations list

        //    Console.WriteLine("");
        //    Console.WriteLine("Enter Starting Station");
        //    Console.ReadLine();

        //3) Ask user which station they want to destination from the stations list

        //    Console.WriteLine("Enter End Station");
        //    Console.ReadLine();

        //4) call path = TubeController.GetShortestPath(startstation, endstation)
        //5) call PrintPath(path) (function originally in TubeController.PrintPath())


        ////Display station info we are going to give the user the ability to view information on a station 

        private Station displayStationInfo()
        {

            //1) Get stations list from tube controller

            Console.WriteLine();

            Console.WriteLine("Station Information");

            var id = _tbc.getStations();
            int index = 1;

            foreach (Station station in id)
            {
                Console.WriteLine("{0} - {1}", index++, station.ToString());
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Please select the Station for further information");
                    return id[Convert.ToInt32(Console.ReadLine())];

                }
                catch
                {
                    Console.WriteLine("Incorrect option, please try again");
                }

            }
        }


        //    //2) Ask user which station they want to view from the stations list
        //    while (true)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine("Enter Station Name for further details: ");
        //        Console.WriteLine();

        //        //3) Use Station.GetStationInfo() to display information(we will need to create a getStationInfo function - ask for help, use ToString for now)

        //        ////Station station = Console.ReadLine();
        //        ////Console.WriteLine();
        //        ////if (_tbc.TubeController().ContainsKey(station))
        //        ////    return station;
        //        //else
        //        //    Console.WriteLine($" {station} does not exist");
        //    }
        //}

        //public void printPath(Path<Platform> path)
        //    {

        //        String getTimeString(int time)
        //        {
        //            return $"{time} min" + (time > 1 ? "s" : "");
        //        }

        //        Console.WriteLine($"Path from {path.startVertex.Station.Name} to {path.destination.Station.Name}");
        //        Console.WriteLine($" - {path.startVertex.Line.Name}: {path.startVertex.Station.Name} ({path.startVertex.Line.Direction})");

        //        int segmentTime = 0;
        //        foreach (Edge<Platform> edge in path.getPath())
        //        {
        //            var connection = edge.Source.getConnection(edge.Target);

        //            if (connection.mode == ModeType.Interchange)
        //            {
        //                Console.WriteLine($" - {getTimeString(segmentTime)}");
        //                Console.WriteLine($" - {edge.Source.Line.Name}: {edge.Source.Station.Name} ({edge.Source.Line.Direction}) --  ");
        //                Console.WriteLine($"Change lines {edge.Weight} min" + (edge.Weight > 1 ? "s" : ""));
        //                Console.WriteLine($" - {edge.Target.Line.Name}: {edge.Target.Station.Name} ({edge.Target.Line.Direction}) ");
        //            }
        //            else
        //            {
        //                segmentTime += edge.Weight;
        //            }
        //        }
        //        Console.WriteLine($" - {getTimeString(segmentTime)}");
        //        Console.WriteLine($" - {path.destination.Line.Name}: {path.destination.Station.Name} ({path.destination.Line.Direction}) ");

        //        Console.WriteLine($"\n--Total time: {getTimeString(path.weight)}");
        //    }
    }
}
