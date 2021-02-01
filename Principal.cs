using System;

namespace LinkedIn_Learning_C_Sharp
{
    public class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying Principal");
        }
    }
}