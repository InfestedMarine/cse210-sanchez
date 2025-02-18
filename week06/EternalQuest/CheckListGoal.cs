using System;

public class CheckListGoal : Goal{

    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public CheckListGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points){

        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent(){
        _currentCount++;
    }

    public override string GetDetailsString(){

        return $"[{_currentCount}/{_targetCount}] {_name} ({_points} points, {_bonusPoints} bonus on completion)";
    }
}   
