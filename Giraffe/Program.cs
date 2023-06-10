using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TextLooter;

namespace TextLooter 
{
    class Program
    {
        static void Main(string[] args)
        {
            Location.InitLocations();
            Location.FillMyLocations();
            Location.FillMyLocationsStr();
            Story.FillmyStories();
            Date.FillmyDates();

            //linear adventure start
            Story.Intro();
            Prompt.Intro();
            Prompt.IntroLocation();

            //Console.WriteLine(Location.location.latitude + ":" + Location.location.longitude);

            for(int i = 0; i < 5; i++)
            {
                Console.Clear();
                Story.NextStory();
                Prompt.DateOptions();
                Date.Result();
                Location.LocationOptions();
            }
            Console.Clear();
            Story.Outro();

            Console.ReadLine();
        }



    }
}