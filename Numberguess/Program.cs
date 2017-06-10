using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberguess
{
    class Program
    {
         static void Main(string[] args)
        {
            getappinfo();
            greetuser();
            while (true)
            {
                Random random = new Random();
                int correctnumber = random.Next(1, 11);
                int guess = 0;
                Console.WriteLine("guess a number between 1 and 11");
                while (guess != correctnumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        printcolormessage(ConsoleColor.Red, "Please enter a actual number");

                        continue;
                    }
                    guess = Int32.Parse(input);
                    if (guess != correctnumber)
                    {
                        printcolormessage(ConsoleColor.Red, "wrong number, try again");
                    }

                }
                printcolormessage(ConsoleColor.Yellow, "Correct!! You guessed it!");

                Console.WriteLine("Play again?[Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
        static void getappinfo()
        {
            string appname = "guessthenumber";
            string appversion = "1.0.0";
            string appdeveloper = "Raju";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: version {1} by {2}", appname, appversion, appdeveloper);
            Console.ResetColor();

        }
        static void greetuser()
        {
            Console.WriteLine("what is your Name?");
            string inputname = Console.ReadLine();
            Console.WriteLine("hello {0}, let's play a game..", inputname);
        }
        static void printcolormessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
