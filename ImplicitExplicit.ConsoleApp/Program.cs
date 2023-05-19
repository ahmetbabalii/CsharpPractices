

using ImplicitExplicit.ConsoleApp;

CustomDay customDay = new(1);
Console.WriteLine($"Day: {customDay.Day}, DayOfWeek: {customDay.DayOfWeek}, IsWeekDay: {customDay.IsWeekDay}, IsWeekend: {customDay.IsWeekend}");

int day = (int)customDay.DayOfWeek;

#region implicit operator

//int dayNumber = 2;
//CustomDay customAnotherDay = dayNumber;  
//int day2 = customAnotherDay;

#endregion


#region explicit operator
// Özellikle developer'a bunun bir dönüşüm olduğunu göstermek için kullanılır.

int dayNumber = 2;
CustomDay customAnotherDay = (CustomDay)dayNumber;
int day2 = (int)customAnotherDay;

#endregion


Console.ReadLine();