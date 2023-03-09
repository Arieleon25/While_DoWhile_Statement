using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhile_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the country?");
            string Vzla = Console.ReadLine();
            bool isGuessed = Vzla == "Venezuela";

            do
            {
                switch (Vzla)
                {
                    case "USA":
                        Console.WriteLine("You guessed wrong. Try a country more to the south.");
                        Console.WriteLine("Guess the country?");
                        Vzla = Console.ReadLine();
                        break;
                    case "Mexico":
                        Console.WriteLine("You guessed wrong. Try a country more to the south.");
                        Console.WriteLine("Guess the country?");
                        Vzla = Console.ReadLine();
                        break;
                    case "Colombia":
                        Console.WriteLine("You guessed wrong, but you are close. the country shares borders with Colombia");
                        Console.WriteLine("Guess the country?");
                        Vzla = Console.ReadLine();
                        break;
                    case "Brazil":
                        Console.WriteLine("You guessed wrong, but you are close. the country shares borders in the north of Brazil");
                        Console.WriteLine("Guess the country?");
                        Vzla = Console.ReadLine();
                        break;
                    case "Argentina":
                        Console.WriteLine("You guessed wrong, try more north");
                        Console.WriteLine("Guess the country?");
                        Vzla = Console.ReadLine();
                        break;
                    case "Venezuela":
                        Console.WriteLine("You guessed Venezuela. That is correct!");
                        Vzla = Console.ReadLine();
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong. Try in Latin America");
                        Console.WriteLine("Guess the country?");
                        Vzla = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);

            Console.WriteLine("How many states Venezuela has?");
            int States = Convert.ToInt32(Console.ReadLine());
            bool stateGuessed = States == 23;

            while (!stateGuessed)
            {
                switch (States)
                {
                    case 10:
                        Console.WriteLine("You guessed wrong is not 10 states. Try Between 10 and 40");
                        Console.WriteLine("How many states Venezuela has?");
                        States = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 15:
                        Console.WriteLine("You guessed wrong is not 15 states. You are close");
                        Console.WriteLine("How many states Venezuela has?");
                        States = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 30:
                        Console.WriteLine("You guessed wrong is not 30 states. You are close");
                        Console.WriteLine("How many states Venezuela has?");
                        States = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed wrong is not 12 states. Try Between 10 and 40");
                        Console.WriteLine("How many states Venezuela has?");
                        States = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 40:
                        Console.WriteLine("You guessed wrong is not 40 states. Too far");
                        Console.WriteLine("How many states Venezuela has?");
                        States = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 23:
                        Console.WriteLine("You guessed 23. That is correct!");
                        stateGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You guessed wrong. Try Between 10 and 40");
                        Console.WriteLine("How many states Venezuela has?");
                        States = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
