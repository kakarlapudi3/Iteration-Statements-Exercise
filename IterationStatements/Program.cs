using System;
using System.Net.NetworkInformation;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Main(string[] args) {
            PrintThousand();
            Threes();
            Console.WriteLine(isEqual(5, 5));
            IsNumberEvenOrOdd();
            IsNumPosOrNeg();
            CanPersonVote();
            IsNumberinRange();
            MultiplicationTable(4);
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool isEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void IsNumberEvenOrOdd ()
        {
            Console.WriteLine("Enter number");
            int userInput = int.Parse(Console.ReadLine());
            
            if (userInput % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

        }
        //Write a method to check whether a given number is positive or negative

        public static void IsNumPosOrNeg()
        {
            Console.WriteLine("Enter number");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CanPersonVote()
        {
            Console.WriteLine("Enter age of person");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 18)
            {
                Console.WriteLine("Candidate can vote");
            }
            else
            {
                Console.WriteLine("Candidate can vote");
            }

        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void IsNumberinRange()
        {
            Console.WriteLine("Enter integer");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("Number is in the range");
            }
            else
            {
                Console.WriteLine("Number is not in the range");
            }

        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplicationTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i*num}");
            }
        }

        //Call the methods to test them in the Main method below

    }
}
