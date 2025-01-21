using System;
using System.Collections.Generic;

class Journal{

    private List<Entry> _entries = new List<Entry>();
    private string[] _prompts = new string[]{

        "Soo what's the most interesting that happened to your day?",
        "Did you have a great time?",
        "Did you accomplish anything for yourself?",
        "Whatcha learned today?",
        "Did you practice your coding?"
    };

    public void AddEntry(){
        
        var random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length    )];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your reponse: ");
        string response = Console.ReadLine();

        _entries.Add(new Entry(prompt, response));
        Console.WriteLine("Entry Added. \n");
    }

    public void DisplayEntries(){
        
        if (_entries.Count == 0){
            
            Console.WriteLine("You have not written any entries. \n");
            return;
        }

        Console.WriteLine("Journal Entries:");
        foreach (var entry in _entries) {
            
            Console.WriteLine(entry.ToSimpleString());
        }

        Console.WriteLine();
    }
}