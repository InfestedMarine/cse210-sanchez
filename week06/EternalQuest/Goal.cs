using System;


public abstract class Goal{
    
    protected string _name;
    protected int _points;

    public Goal(string name, int points){

        _name = name;
        _points = points;
    }

    public string GetName(){
        
        return _name;
    }

    public int GetPoints(){

        return _points;
    }

    public abstract void RecordEvent();
    public abstract string GetDetailsString();
}