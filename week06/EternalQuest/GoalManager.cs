using System;
using System.Collections.Generic;


public class GoalManager{

    private List<Goal> _Goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal){

       _Goals.Add(goal);
    }

      public void RecordEvent(string goalName){
        foreach (var goal in _Goals) {
            if (goal.GetName() == goalName){  
                goal.RecordEvent();
                _score += goal.GetPoints();
            }
        }
    }

    public void ShowGoals(){

        if(_Goals.Count == 0){
            Console.WriteLine("No goals available. Add a goal to get started!");
            return;
        }
        foreach(var goal in _Goals){
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ShowScore(){
        
        Console.WriteLine($"Current Score: {_score}");
    }

    public void UserCreateGoal(){

        Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist");
        string choice = Console.ReadLine();
        
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("Enter Points : ");

        
        if(choice == "1"){
            AddGoal(new SimpleGoal(name, points));
        } else if (choice == "2"){
            AddGoal(new EternalGoal(name, points));
        } else if (choice == "3"){
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            
            AddGoal(new CheckListGoal(name, points, target, bonus));
        }

    }
    
}

