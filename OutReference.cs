using System;

namespace LinkedIn_Learning_C_Sharp
{
    public class OutReference
    {
        /*static void Main(string[] args)
        {
            var x = 2;
            
            Console.WriteLine(x);
            
            Double(ref x);
            
            Console.WriteLine(x);
        }*/

        static void Five(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }
        static void Double(ref int a)
        {
            a = a * 2;
            Console.WriteLine(a);
        }
    }
}