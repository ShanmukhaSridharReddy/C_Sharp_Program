using System;
using System.Collections.Generic;
using System.Text;

namespace DateAndTimeReview
{
    public class DataTime
    {
        public static void date()
        {
            Console.WriteLine("Enter Day");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Month");
            int Month=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            DateTime datetime= DateTime.Now;
            DateTime user = new DateTime(year, Month, day);
            DateTime nextdate = DateTime.Now.AddHours(24);
        }
    }
}
