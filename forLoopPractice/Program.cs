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
            Console.WriteLine("\nThe sum is: " + b);

            //Problem 3
            Console.WriteLine("\nProblem Three - Have the user enter a number and then print out every number leading up to it and then find the sum of all numbers");
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

            //Problem 4 have the user enter numbers 1 - 10 and then find the sum and average of those numbers
            int problem4Sum = 0;
            float problem4Avg;
            Console.WriteLine("\nProblem Four - Have the User enter numbers 1-10, then find the sum and average of those numbers");
            for(int problem4 = 1; problem4 < 11; problem4++)
            {
                Console.Write("Enter Number-{0}: ", problem4);
                int problem4UserInput = Convert.ToInt32(Console.ReadLine());
                problem4Sum = problem4Sum + problem4;
            }
            problem4Avg = problem4Sum / 10.0f;
            Console.WriteLine("\nThe sum of those numbers is: " + problem4Sum);
            Console.WriteLine("\nThe average of those numbers is: " + problem4Avg);



        }
    }
}
