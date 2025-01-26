using System;

class Program
{
    static void Main(string[] args)
    {
        
        var reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that He gave His one and only Son";

        var scripture = new Scripture(reference, scriptureText);

        while(true){
            
            scripture.DisplayText();

            Console.WriteLine("\n Press Enter to hide a word, or type 'Quit' to exit.");
            string userInput = Console.ReadLine();

            if(userInput.ToLower() == "quit"){

                break;
            }

            scripture.HideRandomWrds();
        }

        scripture.DisplayText();
    }
}