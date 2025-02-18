using System;


public class SimpleGoal : Goal{

    private bool _IsComplete;

    public SimpleGoal(string name, int points) : base(name, points){

        _IsComplete = false;
    }

    public override void RecordEvent()
    {
        _IsComplete = true;
    }

    public override string GetDetailsString()
    {
        return $"[ {(_IsComplete ? "X" : " ")}] {_name} ({_points} points)";
    }
}