using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Cyan's Bizzare Magical Number Game! \n The Simple and only Rule is to guess the number!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        int guess = 0;

        while (guess != magicNumber){
            Console.Write("What's your guess? " );
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess){
                Console.WriteLine("Oo Warmer");
            }
            else if (magicNumber < guess){
                Console.WriteLine("Aw Colder");
            }
            else {
                Console.WriteLine("You've have guessed it! Congrats!");
            }
            
        
        }


    }
}