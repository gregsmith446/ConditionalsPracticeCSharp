using System;

// simple program takes user input
// if that number is between 1 and 10 it writes to console "valid"
// if the number is not between 1 and 10, program returns and writes to console "invalid"

namespace MoshConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 10 please.");

            var userInput = Console.ReadLine();

            var number = Convert.ToInt32(userInput);

            if (number >= 1 && number <= 10) 
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
