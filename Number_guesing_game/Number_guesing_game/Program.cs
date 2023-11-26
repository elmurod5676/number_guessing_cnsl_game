using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guesing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int returnValue = random.Next(1, 60);
            int Guess = 0;

            Console.WriteLine("I am thinking of a number between 1-60.  Can you guess what it is?");

            while (Guess != returnValue)
            {
                Guess = Convert.ToInt32(Console.Read());

                while (Guess < returnValue)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + Guess + " .  Can you guess what it is?");
                    Console.ReadLine();

                }
                while (Guess > returnValue)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + Guess + " .  Can you guess what it is");
                    Console.ReadLine();
                }
            }
            while (Guess == returnValue)
            {
                Console.WriteLine("Well done! The answer was " + returnValue);
                Console.ReadLine();
            }
        }
    }
}
