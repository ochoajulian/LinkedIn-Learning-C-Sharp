using System;
namespace LinkedIn_Learning_C_Sharp
{
    public class Logger
    {
        private const string DefaultSystemName = "SchoolTracker";
        public static void Log(string msg, string system = DefaultSystemName, int priority = 1)
        {
            Console.WriteLine($"System: {system}, Priority: {priority}, Message: {msg}");
        }
    }
}