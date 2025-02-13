using System;

public class ListingActivity : Activity{

    private List<string> _prompt = new List<string>{

        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect on the good things in your life by listing them."){

    }

    public void Run(){

        StartActivity();
        int duration = GetDuration();
        Random rand = new Random();

        Console.WriteLine(_prompt[rand.Next(_prompt.Count)]);
        ShowCountDown(3);

        List<string> response = new List<string>();
        Console.WriteLine("Start listing items");

        DateTime endtime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endtime){

            Console.Write("> ");
            response.Add(Console.ReadLine());
        }

    Console.WriteLine($"You Listed {response.Count} items!");
    EndActivity();
    }
}