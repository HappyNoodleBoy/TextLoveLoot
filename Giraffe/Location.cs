using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TextLooter;

namespace TextLooter
{
    public class Location
    {
        //create the main variable that will be changed & checked to determine progress
        public static Location location = new Location(0, 0, false);
        //setup dictionary and string array for dictionary keys
        public static Dictionary<string, Location> myLocations = new Dictionary<string, Location>(9);
        public static Dictionary<Location, string> myLocationsStr = new Dictionary<Location, string>(9);
        static List<string> unaccessedLocations = new List<string>();
        public static string[] locations = { "City", "Park", "Town", "Woods", "Meadow", "Mountain", "Temple", "Circus", "Gym" };
        //instantiate 9 Location objects with grid pattern parameters
        static Location[] initLocations = new Location[9];
        public static void InitLocations()
        {
            int la = 1;
            int lo = 0;
            for (int i = 0; i < initLocations.Length; i++)
            {
                lo++;
                if (lo > 3)
                {
                    lo = 1;
                    la++;
                }
                initLocations[i] = new Location(la, lo, false);
            }
        }
        //populate dictionary with string array and Location array
        public static void FillMyLocations()
        { 
            for (int i = 0; i< 9; i++)
            {
                myLocations.Add(Location.locations[i], initLocations[i]);
            }
        }
        public static void FillMyLocationsStr()
        {
            for (int i = 0; i < 9; i++)
            {
                myLocationsStr.Add(myLocations.ElementAt(i).Value, myLocations.ElementAt(i).Key);
            }
        }

        public int latitude;
        public int longitude;
        public bool accessed;

        public Location(int aLatitude, int aLongitude, bool aAccessed) 
        {
            longitude = aLongitude;
            latitude = aLatitude;
            accessed = aAccessed;
        }
        public Location(int aLatitude, int aLongitude)
        {
            longitude = aLongitude;
            latitude = aLatitude;
        }
        public static void LocationOptions()
        {
            Console.Clear();
            Console.WriteLine("Where will life take you now?");
            Console.WriteLine();

            if (CompareIfAdjacentLocationValid(1, 0))
            {
                Console.WriteLine("north: {0}", myLocationsStr[GetAdjacentLocation(1,0)]);
            }
            if (CompareIfAdjacentLocationValid(-1, 0))
            {
                Console.WriteLine("south: {0}", myLocationsStr[GetAdjacentLocation(-1, 0)]);
            }
            if (CompareIfAdjacentLocationValid(0, 1))
            {
                Console.WriteLine("east: {0}", myLocationsStr[GetAdjacentLocation(0, 1)]);
            }
            if (CompareIfAdjacentLocationValid(0, -1))
            {
                Console.WriteLine("west: {0}", myLocationsStr[GetAdjacentLocation(0, -1)]);
            }

            if (!Location.CompareIfAdjacentLocationValid(1, 0) && !Location.CompareIfAdjacentLocationValid(-1, 0) && !Location.CompareIfAdjacentLocationValid(0, 1) && !Location.CompareIfAdjacentLocationValid(0, -1))
            {
                Console.WriteLine("You feel faint. What were you going to do again? . . . You black out\n(Enter)");
                Location.location = Location.GetRandomUnaccessedLocation();
                Location.location.accessed = true;
                Console.ReadLine();
                goto Forward;
            }

            Prompt.NSEW();

            switch (Prompt.answer)
            {
                case "north": 
                    location = GetAdjacentLocation(1, 0);
                    location.accessed = true;
                    break;
                case "south":
                    location = GetAdjacentLocation(-1, 0);
                    location.accessed = true;
                    break;
                case "east":
                    location = GetAdjacentLocation(0, 1);
                    location.accessed = true;
                    break;
                case "west":
                    location = GetAdjacentLocation(0, -1);
                    location.accessed = true;
                    break;
            }
        Forward:;
        }
        static Location GetAdjacentLocation(int latdif, int londif)
        {
            Location adjLocation = new Location(location.latitude, location.longitude, location.accessed);
            adjLocation.latitude += latdif;
            adjLocation.longitude += londif;

            for (int i = 0; i < locations.Length; i++)
            {
                if (adjLocation.latitude == myLocations[locations[i]].latitude && adjLocation.longitude == myLocations[locations[i]].longitude)
                {
                    return myLocations[locations[i]];
                }
            }
            return myLocations[locations[3]];
        }

        public static bool CompareIfAdjacentLocationValid(int latdif, int londif)
        {
            Location adjLocation = new Location(location.latitude, location.longitude, location.accessed);
            adjLocation.latitude += latdif;
            adjLocation.longitude += londif;

            for (int i = 0; i < locations.Length; i++)
            {
                if (adjLocation.latitude == myLocations[locations[i]].latitude && adjLocation.longitude == myLocations[locations[i]].longitude && myLocations[locations[i]].accessed == false)
                {
                    return true;
                }
            }
            return false;
        }
        public static Location GetRandomUnaccessedLocation()
        {
            for(int i = 0; i < locations.Length; i++)
            {
                if (!myLocations[locations[i]].accessed)
                {
                    unaccessedLocations.Add(locations[i]);
                }
            }
            List<string> randomUnaccessed = unaccessedLocations.OrderBy(x => Date.rnd.Next()).ToList();

            return myLocations[unaccessedLocations[0]];
        }
    
    }
}
