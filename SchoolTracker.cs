using System;
using System.Collections.Generic;
using System.Threading;

namespace LinkedIn_Learning_C_Sharp
{
    public class SchoolTracker
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            
                
            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Enter student's name:");

                    newStudent.Grade = Util.Console.AskInt("Enter student's grade:");

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
            foreach (var student in students)
            {
                Console.WriteLine("Student:" + student.Name + " Grade:" + student.Grade);
            }
        }

        static void Import()
        {
            var importedStudent = new Student("Alison", 98, "November", "Ravencrest", 719);
            Console.WriteLine(importedStudent.Name);
        }
    }

    class Member
    {
        public string Name;
        public int Grade;
        protected int phone;
        public int Phone
        {
            set { phone = value; }
        }
    }
    class Student : Member
    {
        static public int Count = 0;
        
        
        public string Birthday;
        public string Address;
        
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

    class Teacher : Member
    {
        public string Subject;
    }
}