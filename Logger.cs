using System;
namespace LinkedIn_Learning_C_Sharp
{
    public class Logger
    {
        public static void Log(string msg, int priority, string system)
        {
            Console.WriteLine("System: {0}, Priority: {1}, Message: {2}",system, priority, msg);
        }
    }
}