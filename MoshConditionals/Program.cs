using System;

// simple program takes user input --> 2 integers
// writes to console which number is bigger or writes that they are the same

namespace MoshConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");

            var inputOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");

            var inputTwo = Convert.ToInt32(Console.ReadLine());

            if (inputOne > inputTwo)
            {
                Console.WriteLine(inputOne + " is the larger number");
            }
            else if (inputTwo > inputOne)
            {
                Console.WriteLine(inputTwo + " is the larger number");
            }
            else if (inputTwo == inputOne)
            {
                Console.WriteLine("{0} and {1} are the same number!", inputOne, inputTwo);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
