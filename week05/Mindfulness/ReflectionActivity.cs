using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity{

    private List<string> _prompt = new List<string>{

        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _question = new List<string>{

        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?",
        "How can you apply this in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity helps you reflect on times in your life when you have shown strength and resilience."){

    }

    public void Run(){

        StartActivity();
        int duration = GetDuration();
        Random rand = new Random();

        Console.WriteLine(_prompt[rand.Next(_prompt.Count)]);
        ShowSpinner(3);

        for (int i = 0; i < duration / 5; i++){

            Console.WriteLine(_question[rand.Next(_question.Count)]);
            ShowSpinner(5);
        }

    EndActivity();
    }
}