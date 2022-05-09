using System;

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

        private void engineersMenu()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to the Engineers Menu");
                Console.WriteLine(" - Press (0) to Return to Main Menu");
                Console.WriteLine(" - Press (1) to Add Delay to a Line");
                Console.WriteLine(" - Press (2) to Remove Delay from a Line");
                Console.WriteLine(" - Press (3) to Close a Track Section");
                Console.WriteLine(" - Press (4) to Open a Track Section");
                Console.WriteLine(" - Press (5) to Show Closed Track Sections");
                Console.WriteLine(" - Press (6) to Show Delayed Track Sections");
                Console.Write("Please enter an option: ");
                switch (Console.ReadLine())
                {
                    case "0":
                        mainMenu();
                        break;
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
                        ListClosures();
                        break;
                    case "6":
                        ListDelays();
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please enter an option from 0 to 6");
                        break;
                }
            }
        }

        private void AddDelayMenu()
        {

            Console.WriteLine();

            Console.WriteLine("Add Delay");
            Console.WriteLine("Please select the line to add a delay");
            Line selectedLine = getItemfromList<Line>(_tbc.getLines());

            Console.WriteLine("Please select the station where the delay starts");
            Station startStation = getItemfromList<Station>(selectedLine.getStations());
   
            var delay = getDouble("How long is the delay?");
            var reason = getString("Why is there a delay?");

            var trackDelay = _tbc.AddDelayToLine(selectedLine, startStation, reason, delay);
            while (conditional($"Do you want to expand the delay to {trackDelay.getNextStation().Name}? (y/N)")){
                var newDelay = getDouble("How long is the delay?");
                _tbc.ExpandDelay(trackDelay, newDelay);
            }

            Console.WriteLine(trackDelay.ToString());
        }

        private void RemoveDelayMenu() {
            Console.WriteLine();

            var delays = _tbc.getDelays();
            if (delays.getLength() == 0){
                Console.WriteLine("No track delays");
                return;
            }

            Console.WriteLine("Remove Delay");
            Console.WriteLine("Please select the delay to remove");
            TrackDelay selectedDelay = getItemfromList<TrackDelay>(delays);
            _tbc.RemoveDelay(selectedDelay);

            Console.WriteLine("Delay Removed");

        }

        private void CloseSectionOfTrack()
        {
            Console.WriteLine();

            Console.WriteLine("Add Closure");
            Console.WriteLine("Please select the line to add a closure");
            Line selectedLine = getItemfromList<Line>(_tbc.getLines());

            Console.WriteLine("Please select the station where the closure starts");
            var stations = selectedLine.getStations();
            stations.RemoveLast();
            Station startStation = getItemfromList<Station>(stations);
            
            Console.WriteLine("Please select the station where the closure end");
            Station endStation = getItemfromList<Station>(selectedLine.getStationsAfter(startStation));

            var reason = getString("Why is there a closure?");

            var closure = _tbc.CloseSectionOfTrack(selectedLine, startStation, endStation, reason);

            Console.WriteLine();
            Console.WriteLine(closure.ToString());
        }

        private void ReopenSectionOfTrack() {
            Console.WriteLine();

            var closures = _tbc.getClosures();
            if (closures.getLength() == 0){
                Console.WriteLine("No track closures");
                return;
            }

            Console.WriteLine("Reopen Closure");
            Console.WriteLine("Please select the closure to reopen");
            TrackClosure selectedClosure = getItemfromList<TrackClosure>(closures);
            _tbc.ReopenSectionOfTrack(selectedClosure);

            Console.WriteLine("Track Reopened");

        }

        private void ListClosures(){
            Console.WriteLine();

            var closures = _tbc.getClosures();
            if (closures.getLength() == 0){
                Console.WriteLine("No track closures");
                return;
            }

            Console.WriteLine("Active Track Closures");
            var index=0;
            foreach(TrackClosure closure in _tbc.getClosures()){
                Console.WriteLine("{0}\t - {1}", index++, closure.ToString());
            }
        }

        private void ListDelays(){
            Console.WriteLine();

            var delays = _tbc.getDelays();
            if (delays.getLength() == 0){
                Console.WriteLine("No track delays");
                return;
            }

            Console.WriteLine("Active Track Delays");
            var index=0;
            foreach(TrackDelay delay in _tbc.getDelays()){
                Console.WriteLine("{0}\t - {1}", index++, delay.ToString());
            }
        }

        private bool conditional(string message){
            Console.WriteLine(message);
            while(true){
                try {
                    switch(Console.ReadLine().ToUpper()){
                    case "Y":
                        return true;
                    case "N":
                        return false;
                    }
                }
                catch {
                    Console.WriteLine("Invalid entry, please try again. Must be y or n.");
                }
            }
        }

        private Double getDouble(string message) {
            Console.WriteLine(message);
            while(true){
                try {
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Invalid entry, please try again. Must be a decimal number.");
                }
            }
        }

        private String getString(string message) {
            Console.WriteLine(message);
            while(true){
               // Console.WriteLine("Please enter some text: ");
                try {
                    return Console.ReadLine();
                }
                catch {
                    Console.WriteLine("Invalid entry, please try again");
                }
            }
        }


        private T getItemfromList<T>(List<T> items){
            int index=0;
            foreach(T item in items){
                Console.WriteLine("{0} -\t{1}", index++, item.ToString());
            }
            
            while (true)
            {
                try
                {
                    Console.Write("Please enter an index: ");
                    return items[Convert.ToInt32(Console.ReadLine())];
                }
                catch
                {
                    Console.WriteLine("Incorrect option, please try again");
                }
            }

        }

        String getTimeString(double time)
            {
                int integer = (int) time;
                var seconds = time - integer;
                seconds = (int) (60 / (1/seconds));
                return $"{integer}:{seconds} min" + (time > 1.0 ? "s" : "");
            }


        private void customerMenu()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to Customer Journey Planner Menu");
                Console.WriteLine(" - Press (0) to Return to Main Menu");
                Console.WriteLine(" - Press (1) to find Fastest Route");
                Console.WriteLine(" - Press (2) to display Station Information");
                Console.WriteLine("Please enter an option: ");
                switch (Console.ReadLine())
                {
                    case "0":
                        mainMenu();
                        break;
                    case "1":
                        findFastestRoute();
                        break;
                    case "2":
                        displayStationInfo();
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please enter an option from 0 to 2");
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

            Console.WriteLine("Please select the starting station");
            Station startStation = getItemfromList<Station>(_tbc.getStations().Sort<Station>());

            Console.WriteLine("Please select the destination");
            var destinations = _tbc.getStations().Sort<Station>();
            destinations.RemoveItem(startStation);
            Station destination = getItemfromList<Station>(destinations);
            
            var path = _tbc.getShortestPath(startStation, destination);
            if (path == null){
                Console.WriteLine("No route available!");
            }
            else
                printPath(path);

        }



        ////Display station info we are going to give the user the ability to view information on a station 

        private void displayStationInfo()
        {

            Console.WriteLine();
            Console.WriteLine("Station Information");

            Console.WriteLine("Please select a station");
            Station station = getItemfromList<Station>(_tbc.getStations().Sort<Station>());
            
            Console.WriteLine();
            Console.WriteLine(station.LongString());

        }

        private void printPath(Path<Platform> path)
           {



               Console.WriteLine($"\nFastest Route from {path.startVertex.Station.Name} to {path.destination.Station.Name}");
               Console.WriteLine($"\n - {path.startVertex.Line.Name} ({path.startVertex.Line.Direction}): {path.startVertex.Station.Name} ");

               double segmentTime = 0;
               foreach (Edge<Platform> edge in path.getPath())
               {
                   var connection = edge.Source.getConnection(edge.Target);

                   if (connection.mode == ModeType.Interchange)
                   {
                       Console.WriteLine($" >>> {getTimeString(segmentTime)}");
                       Console.WriteLine($" - {edge.Source.Line.Name} ({edge.Source.Line.Direction}): {edge.Source.Station.Name}  ");
                       Console.WriteLine($"\n >>> Change lines {getTimeString(edge.Weight)} \n");
                       Console.WriteLine($" - {edge.Target.Line.Name} ({edge.Target.Line.Direction}): {edge.Target.Station.Name}  ");
                   }
                   else
                   {
                       segmentTime += edge.Weight;
                   }
               }
               Console.WriteLine($" >>> {getTimeString(segmentTime)}");
               Console.WriteLine($" - {path.destination.Line.Name} ({path.destination.Line.Direction}): {path.destination.Station.Name}  ");

               Console.WriteLine($"\n-- Total time: {getTimeString(path.weight)}");
           }
    }
}
