using System;
using System.Threading;

public abstract class Activity{

    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description){
        
        _name = name;
        _description = description;
    }

    public void ShowSpinner(int seconds){

        string[] spinner = { "/", "-", "\\", "|"};

        for(int i = 0; i < seconds * 4; i++){

            Console.Write(spinner[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void StartActivity(){
        
        Console.Clear();
        Console.WriteLine($"Starting {_name} Activity...");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in second: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get Ready...");

        ShowSpinner(3);
    }

    public void EndActivity(){

        Console.WriteLine("Great Job! You have completed the activity.");
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public int GetDuration(){

        return _duration;
    }

    public void ShowCountDown(int seconds){

            for(int i = seconds; i > 0; i--){

                Console.Write( i + " ");
                Thread.Sleep(1000);
            }

        Console.WriteLine();
    }
}