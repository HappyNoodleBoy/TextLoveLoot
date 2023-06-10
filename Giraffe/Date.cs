using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLooter
{
    internal class Date
    {
        public static string[] dates = { "The redhead", "The blonde", "The punk rocker", "The goth", "The raver", "The nerd", "The asian", "The dark skinned goddess", "The Christian", "The stoner", "The black king", "The trippy hippy", "The artist" };
        public static Dictionary<string, Action> myDates = new Dictionary<string, Action>(dates.Length);
        public static Action[] dateResult = { () => TheReadhead(), () => TheBlonde(), () => ThePunkRocker(), () => TheGoth(), () => TheRaver(), () => TheNerd(), () => TheAsian(), () => TheDarkSkinnedGoddess(), () => TheChristian(), () => TheStoner(), () => TheBlackKing(), () => TheTrippyHippy(), () => TheArtist() };

        public static Random rnd = new Random();
        public static string[] randomDates = dates.OrderBy(x => rnd.Next()).ToArray();

        public static int date;
        public static int dateOption1 = -2;
        public static int dateOption2 = -1;

        public static void FillmyDates()
        {
            for(int i = 0; i < dates.Length; i++)
            {
                myDates.Add(dates[i], dateResult[i]);
            }
        }

        public static void Result()
        {
            myDates[randomDates[date]]();
        }
        public static void TheReadhead()
        {
            Console.WriteLine("You hit it off so natural together. Everything was easy. You gained a new appreciation for a human simply being human.\nYou were both so free and easy that you just went separate ways (Enter)");
            Console.ReadLine();
        }
        public static void TheBlonde()
        {
            Console.WriteLine("So nervous. So intelligent. So exciting. So passionate. So uncertain. So controlling. So abusive.\nYou will always remember this one. (Enter)");
            Console.ReadLine();
        }
        public static void ThePunkRocker()
        {
            Console.WriteLine("Avenged Sevenfold is playing tonight. Do you want to go? My eardrums hurt but it was worth it.\nWait, aren't you supposed to be hooking up with me?! (Enter)");
            Console.ReadLine();
        }
        public static void TheGoth()
        {
            Console.WriteLine("Why do I even try anymore? Snuggle me. I don't want to cry anymore. Light a candle for Satan. Did you ever try a threesome?\nUh oh. . . (Enter)");
            Console.ReadLine();
        }
        public static void TheRaver()
        {
            Console.WriteLine("What's in their mouth? This music sounds great. Everything feels amazing. . You feel amazing. You want to touch them more.\nGood morning! Uh... good morning? I'm all alone :( (Enter)");
            Console.ReadLine();
        }
        public static void TheNerd()
        {
            Console.WriteLine("Will you play Pokemon with me? I choose Eiscue! I choose Pidgey! I choose Meltan!! Can we go to the skate park now?\n. . .Will you play Pokemon with me? (Enter)");
            Console.ReadLine();
        }
        public static void TheAsian()
        {
            Console.WriteLine("You have the same taste in food! (Enter)");
            Console.ReadLine();
        }
        public static void TheDarkSkinnedGoddess()
        {
            Console.WriteLine("She asks what you're thinking. You tell her ;) This is someone you will worship forever. .\nOr did you ever worship her at all? (Enter)");
            Console.ReadLine();
        }
        public static void TheChristian()
        {
            Console.WriteLine("You stay up talking all night. And the next night. Their friend are great too. The family is great too! Everything is great.\nWhat do you mean you are moving out of state?? (Enter)");
            Console.ReadLine();
        }
        public static void TheStoner()
        {
            Console.WriteLine("They pass you a lit joint right then and there. You are in heaven together. Who knew life could be so peaceful? Can this really be meant for us?\n" +
                "You run out of weed. Man this sucks. (Enter)");
            Console.ReadLine();
        }
        public static void TheBlackKing()
        {
            Console.WriteLine("He's all that and a bag of Sunchips. In fact he even has a bag. He grabs a handful and shares his treats with you. You gobble it down happily.\n" +
                "He had to go get something he forgot at the store. Maybe you'll see him again one day. (Enter)");
            Console.ReadLine();
        }
        public static void TheTrippyHippy()
        {
            Console.WriteLine("You read each others' star charts. By the end of the week you know everything there is to know about global warming and the war overseas.\n" +
                "You decide to take a trip to South America together for an ayahuasca retreat. You're now dating all of life as a whole. (Enter)");
            Console.ReadLine();
        }
        public static void TheArtist()
        {
            Console.WriteLine("They want to paint you. You go back to their place. They paint you. You watch the sun set. The next day you do something new together you never tried before.\n" +
                "You decide you don't like their political views and go your own way. (Enter)");
            Console.ReadLine();
        }
    }
}
