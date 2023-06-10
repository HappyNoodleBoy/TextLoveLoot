using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TextLooter
{
    public class Story
    {
        public static Dictionary<Location, Action> myStories = new Dictionary<Location, Action>(9);
        public static Action[] stories = { () => CityStory(), () => ParkStory(), () => TownStory(), () => WoodsStory(), () => MeadowStory(), () => FountainStory(), () => TempleStory(), () => CircusStory(), () => GymStory() };
        public static void FillmyStories()
        {
            for(int i = 0; i < 9; i++)
            {
                myStories.Add(Location.myLocations[Location.locations[i]], stories[i]);
            }
        }
        public static void Intro()
        { 
            Console.WriteLine("Valid Commands: yes, no, north, south, east, west, a, b, c, (Enter)");
            Console.WriteLine();
            Console.WriteLine("<3<3<3<3<3<3<3 Are You Ready To Hunt For Love?? <3<3<3<3<3<3<3");
            Console.WriteLine();
        }
        public static void Embark()
        {
            Console.WriteLine("Yay let's go.");
            Console.WriteLine("Track down the Great Significant Other and collect some tools along the way so you have any chance of success.");
            Console.WriteLine("You are riding a train and daydreaming, taking in the views from a window. (Enter)");
            Console.ReadLine();
            Console.WriteLine("Which stop do you step off the train?");
            Console.WriteLine("a: City");
            Console.WriteLine("b: Park");
            Console.WriteLine("c: Town");
        }

        public static void Terminate0()
        {
            Console.WriteLine("Blessings to you on your other quests adventurer. Press Enter to exit");
            Console.ReadLine();
            System.Environment.Exit(0);
        }
        public static void NextStory()
        {
            myStories[Location.location]();
        }
        public static void CityStory()
        {
            Console.WriteLine("You enter the city. You are standing near a Starbucks when a cutie walks by. Is it:");
        }
        
        public static void ParkStory()
        {
            Console.WriteLine("Time for a nice walk in the park. You stop to smell a flower and notice someone else sniffing over yonder. Is it:");
        }
        public static void TownStory()
        {
            Console.WriteLine("A quiet small town. Maybe the local joint serves a good breakfast burrito. That's when you see them. Is it:");
        }
        public static void WoodsStory()
        {
            Console.WriteLine("Finally some peaceful alone time with the sun sparkling down through the canopy. Who's that sitting under a tree?");
        }
        public static void MeadowStory()
        {
            Console.WriteLine("Today might be a good day for a picnic. The rabbits and deer certainly think so. What are the odds someone else is here? Who is it?");
        }
        public static void FountainStory()
        {
            Console.WriteLine("Ohhhhmmmmm. Your favorite place to meditate. Somebody is wishing on a coin. Well, who are you wishing for?");
        }
        public static void TempleStory()
        {
            Console.WriteLine("I've heard this would be a fun and colorful place to visit. It looks like somebody else heard so too! Is it:");
        }
        public static void CircusStory()
        {
            Console.WriteLine("Clowns and lions. Peanuts and popcorn. I wonder what else is in store. Oh my, hello there..! Who is this??");
        }
        public static void GymStory()
        {
            Console.WriteLine("The most satisfying feeling you can get in the gym is called The Pump. Or maybe it's this hottie over here!");
        }



        public static void Outro()
        {
            Console.WriteLine("You're on your way to who-knows-where when you run into an old friend you used to be fond of.\n" +
                "They explain how they are in town for a few months and then planning to go out of country to travel for a while.\n" +
                "You grab lunch the next day at a local sandwich shop. You get to talking and find out you both like frisbee golf, so that happens.\n" +
                "You grab another game the next week too and really enjoy it. You admit you've been thinking of doing a little travelling yourself.\n" +
                "They offer you to travel with them. . ! You've learned and lost a lot from all these encounters you've had lately.\n" +
                "You decide to book a flight and join them on their travels. Little did you know this would be a one-way ticket for the\n" +
                "rest of your life.\n\n\n" +
                "                                          <3<3 THE END <3<3");
        }
    }
}
