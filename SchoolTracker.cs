using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace LinkedIn_Learning_C_Sharp
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT
    }
    public class SchoolTracker
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Logger.Log("Tracker Started" 1, "SchoolTracker", 2);        
            Payroll payroll = new Payroll();
            payroll.PayAll();
            
            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Enter student's name:");

                    newStudent.Grade = Util.Console.AskInt("Enter student's grade:");
                    
                    newStudent.School = (School) Util.Console.AskInt("Enter student's school (corresponding number): \n " +
                                                            "0: Hogwarts High \n 1: Harvard \n 2: MIT \n");

                    newStudent.Birthday = Util.Console.Ask("Enter student's birthday:");

                    newStudent.Address = Util.Console.Ask("Enter student's address:");

                    newStudent.Phone = Util.Console.AskInt("Enter student's phone number:");
                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: " + Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                catch (FormatException message) 
                {
                        Console.WriteLine(message.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error adding student, please try again.");
                    throw;
                }
                
            }
            
            ShowGrade("Julian");
            
            foreach (var student in students)
            {
                Console.WriteLine("Student:" + student.Name + " Grade:" + student.Grade);
            }
            Export();
        }

        static void Import()
        {
            var importedStudent = new Student("Alison", 98, "November", "Ravencrest", 719);
            Console.WriteLine(importedStudent.Name);
        }

        static void Export()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                    {
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    }
                    case School.Harvard:
                    {
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    }
                    case School.MIT:
                    {
                        Console.WriteLine("Exporting to MIT");
                        break;
                    }
                }
            }
        }

        static void ShowGrade(string name)
        {
            var found = students.Find(student => student.Name == name);
            Console.WriteLine(found.Name + "'s Grade: " + found.Grade);
        }
    }

    public class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
    class Student : Member
    {
        static public int Count { get; set; } = 0;

        public int Grade;
        public string Birthday;
        public School School;
        
        public Student()
        {
            
        }
        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
         }
    }
}