using System;

public class BreathingActivity : Activity{

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly."){

    }

    public void Run(){

        StartActivity();
        int duration = GetDuration();

        for (int i = 0; i < duration / 6; i++){

            Console.WriteLine("Breath in...");
            ShowCountDown(3);
            Console.WriteLine("Breath out...");
            ShowCountDown(3);

        }

    EndActivity();
    }
}