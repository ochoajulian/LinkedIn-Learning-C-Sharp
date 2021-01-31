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
                var newStudent = new Student();
                
                newStudent.Name = Util.Console.Ask("Enter student's name:");

                Console.WriteLine("Enter student's grade:");
                newStudent.Grade = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter student's birthday:");
                newStudent.Birthday = Console.ReadLine();
                
                Console.WriteLine("Enter student's address:");
                newStudent.Address = Console.ReadLine();

                Console.WriteLine("Enter student's phone:");
                newStudent.Phone = int.Parse(Console.ReadLine());
                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count: " + Student.Count);
                
                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }
            foreach (var student in students)
            {
                Console.WriteLine("Student:" + student.Name + " Grade:" + student.Grade);
            }
        }
    }

    class Student
    {
        static public int Count = 0;
        
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        public int Phone
        {
            set { phone = value; }
        }
        public void SetPhone(int number)
        {
            phone = number;
        }
    }
}