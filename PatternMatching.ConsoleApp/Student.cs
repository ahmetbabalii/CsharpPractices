namespace PatternMatching.ConsoleApp;

public abstract class Student
{
    public string FullName { get; set; } = "Ahmet Babali";
    public int ExamResult { get; set; }

    public Student(int examResult) => ExamResult = examResult;
}

public class ItStudent : Student
{
    public ItStudent(int examResult) : base(examResult)
    {
        
    }

    public int ComputerExamResult { get; set; }
}

public class MisStudent : Student
{
    public MisStudent(int examResult) : base(examResult)
    {

    }

    public int ProjectManagerExamResult { get; set; }
}