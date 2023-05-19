
using PatternMatching.ConsoleApp;

var studentList = new List<Student>()
{
    new ItStudent(new Random().Next(0, 100)) {ComputerExamResult = 55},
    new MisStudent(new Random().Next(0, 100))
};

var student = studentList[new Random().Next(studentList.Count)];

#region c# 6.0

if (student is ItStudent)
{
    var itStudent = student as ItStudent;
    Console.WriteLine($"ItStudent: {itStudent.FullName}");
}
else if (student is MisStudent)
{
    var misStudent = student as MisStudent;
    Console.WriteLine($"MisStudent: {misStudent.FullName}");
}

#endregion


#region c# 7.0

switch (student)
{
    case ItStudent itStudent:
        Console.WriteLine($"ItStudent: {itStudent.FullName}");
        break;
    case MisStudent misStudent:
        Console.WriteLine($"MisStudent: {misStudent.FullName}");
        break;
}

/********************************************/

var alumni = student switch
{
    ItStudent itStudent => itStudent.ComputerExamResult > 49,
    MisStudent misStudent => misStudent.ProjectManagerExamResult > 59,
    Student s => s.ExamResult > 30,
    _ => false
};

/********************************************/

if (student is ItStudent itStudent2)
    Console.WriteLine($"ItStudent: {itStudent2.FullName}");
else if (student is MisStudent misStudent2)
    Console.WriteLine($"MisStudent: {misStudent2.FullName}");

/********************************************/

if (student is ItStudent itStudent3)
    if (itStudent3.ComputerExamResult > 50 && itStudent3.ComputerExamResult < 100)
        Console.WriteLine("Between 50 and 100");
    else
        Console.WriteLine($"Not Beetween: {itStudent3.ComputerExamResult}");

/********************************************/

if (student is ItStudent { ComputerExamResult: > 50 and < 100 } itStudent4)
    Console.WriteLine($"Between 50 and 100. ExamResult: {itStudent4}");
else
    Console.WriteLine("Not Beetween");

/********************************************/

if (student is ItStudent || student is not MisStudent { ProjectManagerExamResult: > 30 })
{
    Console.WriteLine($"ItStudent or MisStudent with ProjectManagerExamResult > 30. StudentType : {student.GetType().Name}");
    if (student is MisStudent mis)
    {
        Console.WriteLine($" Result: {mis.ProjectManagerExamResult}");
    }
}

#endregion


Console.ReadLine();