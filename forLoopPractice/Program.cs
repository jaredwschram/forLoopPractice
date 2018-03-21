using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            Console.WriteLine("Problem One - Print out Numbers 1 - 10");
            for (int a = 1; a < 11; a++)
            {
                Console.Write("{0} ", a);
            }

            //Problem 2
            Console.WriteLine();
            Console.WriteLine("\nProblem Two - Print out numbers 1- 10 and find the sum of those numbers");
            int b = 0;
            for(int a = 1; a < 11; a++)
            {
                b = b + a;
                Console.Write("{0} ", a);
            }
            Console.WriteLine("The sum is: " + b);

            //Problem 3
            Console.WriteLine("\nProblem Three - Print out N number of items and their sum");
            int c = 0, d = 0;
            Console.WriteLine("\nPlease enter a number: ");
            string userInputString = Console.ReadLine();
            int userInput = Convert.ToInt32(userInputString);

            Console.WriteLine("Your number is " + userInput);
            for (c = 1; c <= userInput; c++)
            {
                d = d + c;
                Console.Write("{0} ",c);
            }
            Console.WriteLine("\nThe Sum of your number is " + d);







        }
    }
}
