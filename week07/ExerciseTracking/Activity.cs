using System;

abstract class Activity{

    protected DateTime _date;
    protected int _durationMinutes;

    public Activity(DateTime date, int durationMinutes){

        _date = date;
        _durationMinutes = durationMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary(){

        return $"{_date: dd MMM yyyy} {GetType().Name} ({_durationMinutes} min): Distance {GetDistance():F1} Km, Speed {GetSpeed():F1} Kph, Pace {GetPace():F2} min per Km";
    }
}