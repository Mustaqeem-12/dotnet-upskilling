                                  // day-7 Crud using Console Application
using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public int Class;
    public int Marks;
}
class Program
{
    static List<Student> students = new List<Student>();
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nStudent Management System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");

            Console.Write("Choose option (1 - 5): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    ViewStudents();
                    break;

                case 3:
                    UpdateStudent();
                    break;

                case 4:
                    DeleteStudent();
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter ID: ");
        s.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Class (1 - 12): ");
        s.Class = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks: ");
        s.Marks = Convert.ToInt32(Console.ReadLine());

        students.Add(s);

        Console.WriteLine("Student added successfully.");
    }
    static void ViewStudents()
    {
        foreach (var s in students)
        {
            Console.WriteLine($"Id:{s.Id}  Name:{s.Name}  Class:{s.Class}  Marks:{s.Marks}");
        }
    }
    static void UpdateStudent()
    {
        Console.Write("Enter Student ID to Update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (var s in students)
        {
            if (s.Id == id)
            {
                Console.Write("Enter new Name: ");
                s.Name = Console.ReadLine();

                Console.Write("Enter new Marks: ");
                s.Marks = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new Class: ");
                s.Class = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Student has updated successfully.");
                return;
            }
        }
        Console.WriteLine("Student not found.");
    }
    static void DeleteStudent()
    {
        Console.Write("Enter Student ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        students.RemoveAll(s => s.Id == id);

        Console.WriteLine("Student deleted.");
    }
}
