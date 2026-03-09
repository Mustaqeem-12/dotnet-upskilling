//   day 6 mini Oop
using System;

// Interface
interface IEmployee
{
    void Work();
}
class Employee
{
    public int Id;
    public string Name;

    public void Display()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
    }
}

class Developer : Employee, IEmployee
{
    public void Work()
    {
        Console.WriteLine("Developer is writing code.");
    }
}
class Manager : Employee, IEmployee
{
    public void Work()
    {
        Console.WriteLine("Manager is managing the team.");
    }
}
class Program
{
    static void Main()
    {
        Developer dev = new Developer();
        dev.Id = 101;
        dev.Name = "Mustaqeem";

        Console.WriteLine("Developer Details:");
        dev.Display();
        dev.Work();

        Console.WriteLine();

        Manager mgr = new Manager();
        mgr.Id = 102;
        mgr.Name = "Ali";

        Console.WriteLine("Manager Details:");
        mgr.Display();
        mgr.Work();
    }
}
