

namespace ImplicitExplicit.ConsoleApp;

public struct CustomDay
{
    public int Day { get; set; }

    public CustomDay(int day) : this()
    {
        if (day > 6)        
            throw new ArgumentOutOfRangeException(nameof(day));
        
        Day = day;
        DayOfWeek = (DayOfWeek)day;
    }

    public DayOfWeek DayOfWeek { get; }
    public bool IsWeekDay => Day >= 1 && Day <= 5;
    public bool IsWeekend => !IsWeekDay;

    #region implicit operator
    //public static implicit operator int(CustomDay customDay) => customDay.Day;

    //public static implicit operator CustomDay(int day) => new(day);
    #endregion

    #region explicit operator
    public static explicit operator int(CustomDay customDay) => customDay.Day;

    public static explicit operator CustomDay(int day) => new(day);
    #endregion
}
