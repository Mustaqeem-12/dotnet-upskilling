using System;
using System.Collections.Generic;

public interface IEmployee
{
    void Work();
}
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
public class Developer : Employee, IEmployee
{
    public Developer(int id, string name) : base(id, name) { }
    public override void Work()
    {
        Console.WriteLine($"Developer {Name} is writing code");
    }
}
public class Manager : Employee, IEmployee
{
    public Manager(int id, string name) : base(id, name) { }

    public override void Work()
    {
        Console.WriteLine($"Manager {Name} is managing team");
    }
}

class Program
{
    static void Main()
    {
        List<IEmployee> employees = new List<IEmployee>
        {
            new Developer(101, "Mustaqeem"),
            new Manager(102, "Ali")
        };

        foreach (IEmployee emp in employees)
        {
            emp.Work(); 
        }
    }
}
