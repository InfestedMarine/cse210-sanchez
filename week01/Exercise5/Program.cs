using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        displayMessage();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);


        static void displayMessage(){
            Console.WriteLine("Hello Word");
        }

        static string PromptUserName(){
            Console.Write("What is your full name? ");
            string fullName = Console.ReadLine();

            return fullName;

        }

        static int PromptUserNumber(){
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();

            int parsedNumber = int.Parse(number);

            return parsedNumber;

        }

        static int SquareNumber(int number){
            int square = number * number;

            return square;

        }

        static void DisplayResult(string name, int square){
            Console.Write($"Hello {name}, The square of your number is {square}");

        }

    }
}