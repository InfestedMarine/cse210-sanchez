using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while(true){
            
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Exit");
            Console.Write("Choose Between the 3:");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if(choice =="1"){
                
                journal.AddEntry();
            }
            else if (choice =="2"){

                journal.DisplayEntries();
            }
            else if (choice =="3"){

                Console.WriteLine("Goodbye!");
                break;
            }
            else {
                Console.WriteLine("Invalid Choice. Are you sure your reading?");
            }

            
        }
    }
}