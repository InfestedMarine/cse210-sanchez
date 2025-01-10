using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello User this is a program where you add number to a list and finds the sum and Average of it all! \n to stop listing and get the Sum and Average please just type 0");

        List<int> numbersList = new List<int>();

        int userInput = -1;

        int sum = 0;

    

        while (userInput != 0){
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0){               
                numbersList.Add(userInput);
            }

        } 

        Console.WriteLine("\n You've have entered the following numbers: ");
        foreach (int numbers in numbersList){
            Console.WriteLine($"Number: {numbers}");
             
        }

        foreach (int numbers in numbersList){
            sum += numbers;

        }
        Console.WriteLine($"The total sum: {sum}");

        float average = ((float)sum) / numbersList.Count;
        Console.WriteLine($"The Average: {average}");

        int largestNumber = numbersList[0];

        foreach (int number in numbersList){
            if (number > largestNumber){
                largestNumber = number;

            }

        }

        Console.WriteLine($"The Largest Number in the List : {largestNumber}");
        

    }
}