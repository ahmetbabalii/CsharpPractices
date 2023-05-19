
using ImplicitExplicit.ConsoleApp;
using static ImplicitExplicit.ConsoleApp.EntityMapping;

CustomDay customDay = new(1);
Console.WriteLine($"Day: {customDay.Day}, DayOfWeek: {customDay.DayOfWeek}, IsWeekDay: {customDay.IsWeekDay}, IsWeekend: {customDay.IsWeekend}");
int day = (int)customDay.DayOfWeek;

#region implicit operator example for CustomDay

//int dayNumber = 2;
//CustomDay customAnotherDay = dayNumber;  
//int day2 = customAnotherDay;

#endregion

#region explicit operator example for CustomDay
// Özellikle developer'a bunun bir dönüşüm olduğunu göstermek için kullanılır.

int dayNumber = 2;
CustomDay customAnotherDay = (CustomDay)dayNumber;
int day2 = (int)customAnotherDay;

#endregion


#region implicit operator example for EntityMapping

Person person = new()
{
    Name = "John Doe",
    Age = 30
};

Employee employee = person; // Implicit (Örtük) operatörü
Console.WriteLine($"Employee: {employee.Name}, Age: {employee.Age}, Department: {employee.Department}");

#endregion

#region explicit operator example for Rectangle

Rectangle rectangle = new(3, 4);
double diagonal = rectangle; // Rectangle to diagonal length conversion using Implicit (Örtük) operator

Console.WriteLine($"Width: {rectangle.Width}, Height: {rectangle.Height}");
Console.WriteLine($"Diagonal Length: {diagonal}");

#endregion
Console.ReadLine();