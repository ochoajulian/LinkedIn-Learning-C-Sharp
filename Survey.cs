using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace LinkedIn_Learning_C_Sharp
{
    class Survey
    { 
        class Answer
        {
            public string Name;
            public int Age;
            public string BirthMonth;

            public void Display()
            {
                Console.WriteLine("Thank you for your information " + Name + ".");
                Console.WriteLine("You are " + Age + " years old. You were born in " + BirthMonth + " (great month).");
                
                if (BirthMonth == "December")
                {
                    Console.WriteLine("You are a Sagittarius.");
                }
                else if (BirthMonth == "April")
                {
                    Console.WriteLine("You are a Taurus.");
                }
                else if (BirthMonth == "May")
                {
                    Console.WriteLine("You are a Gemini.");
                }
            }
            
        }

        static public event Action Posted;
        /*static void Main(string[] args)
        {
            var stats = new Stats();
            stats.Start();
            var answerList = new List<Answer>();
            var newAnswer = new Answer();
            Console.WriteLine("What is your name?");
            newAnswer.Name = TryAnswer();
            
            Console.WriteLine("How old are you? (# only please!)");
            newAnswer.Age = int.Parse(TryAnswer());
            
            Console.WriteLine("What month were you born?");
            newAnswer.BirthMonth = TryAnswer();

            if (Posted != null)
            {
                Posted();
            }

            newAnswer.Display();
        }*/
        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything...");
                return Console.ReadLine();
            }
            return answer;
        }
    }
    
}