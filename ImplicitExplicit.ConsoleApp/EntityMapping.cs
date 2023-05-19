namespace ImplicitExplicit.ConsoleApp;

public class EntityMapping
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static implicit operator Employee(Person person)
        {
            return new Employee
            {
                Name = person.Name,
                Age = person.Age,
                Department = "Unknown"
            };
        }
    }

    public  class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }

}
