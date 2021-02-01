using System;

namespace LinkedIn_Learning_C_Sharp
{
    class Teacher : Member, IPayee
    {
        public string Subject { get; set; }

        public void Pay()
        {
            Console.WriteLine("Paying Teacher");
        }
    }
}