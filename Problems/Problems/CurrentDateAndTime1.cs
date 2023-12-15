using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class CurrentDateAndTime1
    {
        public static void DateAndtime()
        {
            DateTime d = DateTime.Now;
            Console.WriteLine("Current date is: " + d.ToShortDateString());
            Console.WriteLine("Current time is: " + d.ToShortTimeString());
        }
    }
}
