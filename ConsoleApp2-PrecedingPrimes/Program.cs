using System;

namespace ConsoleApp2_PrecedingPrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks user to input a number
            Console.WriteLine("Please input a number:");
            //Runs a function that reads the user input string, parses it into an integer, and returns the integer value
            int inputValue = UserInput();
            //Runs a function that takes the integer value and lists all prime numbers preceding it
            ListPrecedingPrimes(inputValue);
        }

        private static int UserInput()
        {
            //Reads the user input
            string userInput = Console.ReadLine();
            //Converts the user input string to an integer and saves it to the variable inputValue
            int inputValue = int.Parse(userInput);
            //Returns the integer value of the user input string
            return inputValue;
        }

        private static void ListPrecedingPrimes(int inputValue)
        {
            //Starting at the number 2, for each number preceding the input integer,...
            for (int i = 2; i <= inputValue; i++)
            {
                //...determine whether each preceding number including the number itself is prime
                isPrime(i);
            }
        }

        //Takes an integer as a parameter, determines whether it is prime, and prints the number to the console if it is prime
        private static void isPrime(int num1)
        {
            //Check if the input number is divisible by each number before it except the number 1
            for (int i = 2; i < num1; i++)
            {
                //If the remainder of the input number divided by any number preceding it is 0,
                //then the number is not prime and we should exit the loop with "return".
                if (num1 % i == 0)
                {
                    return;
                }
            }

            //Otherwise, output the number to the console to our list of prime numbers
            Console.Write($"{num1}, ");
        }
    }
}