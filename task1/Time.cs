namespace task1;

public class Time
{
    private int _hour;
    private int _minute;
    private int _second;

    public Time(){}
    public Time(int hour, int minute, int second)
    {
        _hour=hour;
        _minute=minute;
        _second=second;
    }

    public int Hour {get{return _hour;}set{_hour=value;}}
    public int Minute {get{return _minute;}set{_minute=value;}}
    public int Second {get{return _second;}set{_second=value;}}

    public string ToString()
    {
        return $"{_hour / 10}{_hour % 10}:{_minute / 10}{_minute % 10}:{_second / 10}{_second % 10}";
    }

    public void SetTime(int hour, int minute, int second)
    {
        _hour=hour;
        _minute=minute;
        _second=second;
    }

    public Time nextSecond()
    {
        ++_second;
        if (_second>=60)
        {
            _second=0;
            ++_minute;
            if (_minute>=60)
            {
                _minute=0;
                ++_hour;
                if (_hour>=24)
                {
                    _hour=0;
                }
            }
        }
        return this;
    }
}
