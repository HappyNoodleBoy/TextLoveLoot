using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLooter
{
    public static class Prompt
    {
        static bool answerValid;
        public static string answer;
        public static void YesNo()
        {
            do
            {
                Console.WriteLine();
                Console.Write("yes/no?: ");
                string reply = (Console.ReadLine());
                if (reply == "yes" || reply == "no")
                {
                    answerValid = true;
                }
                else
                {
                    answerValid = false;
                    Console.WriteLine("Invalid command </3");
                }
                answer = reply;
            } while (!answerValid);
        }

        public static void ABC()
        {
            do
            {
                Console.WriteLine();
                Console.Write("a/b/c: ");
                string reply = (Console.ReadLine());
                if (reply == "a" || reply == "b" || reply == "c")
                {
                    answerValid = true;
                }
                else
                {
                    answerValid = false;
                    Console.WriteLine("Invalid command </3");
                }
                answer = reply;
            } while (!answerValid);
        }
        public static void AB()
        {
            do
            {
                Console.WriteLine();
                Console.Write("a/b: ");
                string reply = (Console.ReadLine());
                if (reply == "a" || reply == "b")
                {
                    answerValid = true;
                }
                else
                {
                    answerValid = false;
                    Console.WriteLine("Invalid command </3");
                }
                answer = reply;
            } while (!answerValid);

        }

        static bool northValid;
        static bool southValid;
        static bool eastValid;
        static bool westValid;
        public static void NSEW()
        {
            do
            {
                Console.WriteLine();

                if (Location.CompareIfAdjacentLocationValid(1, 0))
                {
                    Console.Write("north");
                    if (!Location.CompareIfAdjacentLocationValid(-1, 0) && !Location.CompareIfAdjacentLocationValid(0, 1) && !Location.CompareIfAdjacentLocationValid(0, -1))
                    {
                        Console.Write(": ");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                    northValid = true;
                }
                else
                {
                    northValid = false;
                }
                if (Location.CompareIfAdjacentLocationValid(-1, 0))
                {
                    Console.Write("south");
                    if (!Location.CompareIfAdjacentLocationValid(0, 1) && !Location.CompareIfAdjacentLocationValid(0, -1))
                    {
                        Console.Write(": ");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                    southValid = true;
                }
                else
                {
                    southValid = false;
                }
                if (Location.CompareIfAdjacentLocationValid(0, 1))
                {
                    Console.Write("east");
                    if (!Location.CompareIfAdjacentLocationValid(0, -1))
                    {
                        Console.Write(": ");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                    eastValid = true;
                }
                else
                {
                    eastValid = false;
                }
                if (Location.CompareIfAdjacentLocationValid(0, -1))
                {
                    Console.Write("west: ");
                    westValid = true;
                }
                else
                {
                    westValid = false;
                }

                string reply = (Console.ReadLine());
                if (reply == "north" && northValid || reply == "south" && southValid || reply == "east" && eastValid || reply == "west" && westValid)
                {
                    answerValid = true;
                }
                else
                {
                    answerValid = false;
                    Console.WriteLine("Invalid command </3");
                }
                answer = reply;
            } while (!answerValid);
        }
        public static void IntroLocation()
        {
            ABC();
            switch (Prompt.answer)
            {
                case "a":
                    Location.location = Location.myLocations["City"];
                    Location.myLocations["City"].accessed = true;
                    break;
                case "b":
                    Location.location = Location.myLocations["Park"];
                    Location.myLocations["Park"].accessed = true;
                    break;
                case "c":
                    Location.location = Location.myLocations["Town"];
                    Location.myLocations["Town"].accessed = true;
                    break;
            }
        }
        public static void Intro()
        {
            YesNo();
            if (Prompt.answer == "yes")
            {
                Console.Clear();
                Story.Embark();
            }
            else
            {
                Story.Terminate0();
            }
        }
        public static void DateOptions()
        {
            Date.dateOption1 += 2;
            Date.dateOption2 += 2;
            Console.WriteLine("\na: " + Date.randomDates[Date.dateOption1] + "\nb: " + Date.randomDates[Date.dateOption2]);
            AB();
            switch (answer)
            {
                case "a":
                    Date.date = Date.dateOption1;
                    break;
                case "b":
                    Date.date = Date.dateOption2;
                    break;
            }
        }
    }
}
