                                 //Day 05 Oops Class, Object, ConstructorS• Encapsulation
using System;

class Employee
{
    private int empId;
    private string name;
    private double salary;

    public Employee(int id, string empName, double empSalary)
    {
        empId = id;
        name = empName;
        salary = empSalary;
    }

    public void SetSalary(double newSalary)
    {
        if (newSalary > 0)
        {
            salary = newSalary;
        }
        else
        {
            Console.WriteLine("Invalid salary");
        }
    }

    public double GetSalary()
    {
        return salary;
    }
    public void DisplayEmployee()
    {
        Console.WriteLine("\nEmployee Details");
        Console.WriteLine($"ID: {empId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Salary: {salary}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee(101, "Mustaqeem", 50000);
        emp1.DisplayEmployee();
        emp1.SetSalary(60000);

        Console.WriteLine("\nSalary updated by HR.");
        emp1.DisplayEmployee();
    }
}
