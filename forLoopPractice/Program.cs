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

            for (int problem1 = 1; problem1 < 11; problem1++)
            {
                Console.Write("{0} ", problem1);
            }

            //Problem 2
            Console.WriteLine();
            Console.WriteLine("\nProblem Two - Print out numbers 1- 10 and find the sum of those numbers");
            int problem2Sum = 0;

            for (int problem2 = 1; problem2 < 11; problem2++)
            {
                problem2Sum = problem2Sum + problem2;
                Console.Write("{0} ", problem2);
            }
            Console.WriteLine("\nThe sum is: " + problem2Sum);

            //Problem 3
            Console.WriteLine("\nProblem Three - Have the user enter a number and then print out every number leading up to it and then find the sum of all numbers");
            int problem3Sum = 0;
            Console.WriteLine("\nPlease enter a number: ");
            int problem3UserInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number is " + problem3UserInput);
            for (int problem3 = 1; problem3 <= problem3UserInput; problem3++)
            {
                problem3Sum = problem3Sum + problem3;
                Console.Write("{0} ", problem3);
            }
            Console.WriteLine("\nThe Sum of your number is " + problem3Sum);

            //Problem 4
            int problem4Sum = 0;
            float problem4Avg;
            Console.WriteLine("\nProblem Four - Have the User enter numbers 1-10, then find the sum and average of those numbers");

            for (int problem4 = 1; problem4 < 11; problem4++)
            {
                Console.Write("Enter Number-{0}: ", problem4);
                int problem4UserInput = Convert.ToInt32(Console.ReadLine());
                problem4Sum = problem4Sum + problem4;
            }
            problem4Avg = problem4Sum / 10.0f;
            Console.WriteLine("\nThe sum of those numbers is: " + problem4Sum);
            Console.WriteLine("\nThe average of those numbers is: " + problem4Avg);

            //Problem 5
            Console.WriteLine("\nProblem Five - Have the user enter a number and then print out every number up to it then find the cube up to a given int");
            Console.WriteLine("\nPlease enter a number: ");
            int problem5Cube;
            int problem5UserInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + problem5UserInput);
            for (int problem5 = 1; problem5 <= problem5UserInput; problem5++)
            {
                problem5Cube = problem5 * problem5 * problem5;
                Console.WriteLine("{0} cubed is {1} ", problem5, problem5Cube);
            }

            //Problem 6
            Console.WriteLine("\nProblem Six - Have the user enter a number and then display the multiplication table of that integer(1-10)");
            Console.WriteLine("\nPlease enter a number: ");
            int problem6UserInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + problem6UserInput);
            for(int problem6 = 1; problem6 < 11; problem6++)
            {
                Console.WriteLine("{0} * {1} = {2}", problem6UserInput, problem6, problem6UserInput*problem6);
            }


            //Problem 7
            Console.WriteLine("\nProblem Seven - Display the multiplication table from 1 to a number that the user enters");
            Console.WriteLine("\nPlease enter a number: ");

            int problem7UserInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + problem7UserInput);
            for(int problem7 = 1; problem7 < 11; problem7++)
            {
                for(int problem7Nest = 1; problem7Nest <= problem7UserInput; problem7Nest++)
                {
                    if(problem7Nest < problem7UserInput)
                    {
                        Console.Write("{0} * {1} = {2},  ", problem7Nest, problem7, problem7 * problem7Nest);
                    }
                    else
                    {
                        Console.Write("{0} * {1} = {2}  ", problem7Nest, problem7, problem7 * problem7Nest);
                    }
                }
                Console.WriteLine();
            }

            //Problem 8
            Console.WriteLine("\nProblem Eight - have the user specify a number and then display that many odd numbers starting from zero and find their sum");
            Console.WriteLine("\nPlease enter a number: ");
            int problem8UserInput = Convert.ToInt32(Console.ReadLine());
            int problem8Sum = 0;
            Console.WriteLine("The first " + problem8UserInput + " odd numbers are: ");

            for(int problem8 = 1; problem8 <= problem8UserInput; problem8++)
            {
                Console.Write("{0} ", 2 * problem8 -1);
                problem8Sum += 2 * problem8 - 1;
            }
            Console.WriteLine("\nTheir sum is " + problem8Sum);


            //Problem 9
            Console.WriteLine("Problem Nine - Write a loop that builds a right side triangle or half pyramid");

            for (int problem9Row = 0; problem9Row < 5; problem9Row++)
            {
                for(int problem9Column = 0; problem9Column < problem9Row + 1; problem9Column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Problem 10
            Console.WriteLine("Problem Ten - build a triangle that increments the numbers each row in the pyramid a total number of times based on user input");

            Console.WriteLine("Please enter a number: ");
            int problem10UserInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + problem10UserInput);
            for(int problem10 = 1; problem10 <= problem10UserInput; problem10++)
            {
                for(int problem10Num = 1; problem10Num <= problem10; problem10Num++)
                {
                    Console.Write("{0} ",problem10Num);
                }
                Console.WriteLine();
            }







            

        }
    }
}
