using System;

namespace LinkedIn_Learning_C_Sharp
{
    public class Stats
    {
        public void Start()
        {
            Survey.Posted += HasPosted;
        }

        void HasPosted()
        {
            Console.WriteLine("Survey posted, run stats.");
        }
    }
}