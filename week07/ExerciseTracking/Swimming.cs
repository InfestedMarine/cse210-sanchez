using System;

class Swimming : Activity{

    private int _lapCount;
    private const double LapLengthKhm = 50.0 / 1000;

    public Swimming(DateTime date, int durationMinutes, int lapCount) : base(date, durationMinutes){

        _lapCount = lapCount;
    }

    public override double GetDistance() => _lapCount * LapLengthKhm;
    public override double GetSpeed() =>  (GetDistance() / _durationMinutes) * 60;
    public override double GetPace() =>  _durationMinutes / GetDistance();

}