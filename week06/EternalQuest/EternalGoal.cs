using System;


public class EternalGoal : Goal{

    public EternalGoal(string name, int points) : base(name, points){

    }

    public override void RecordEvent(){
        
    }

    public override string GetDetailsString()
    {
        return $"[∞] {_name} ({_points} points each time)";
    }
}