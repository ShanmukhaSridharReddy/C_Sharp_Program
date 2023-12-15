using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class StudentsMarks
    {
  
        static void Main(string[] ags)
        {
            int s1 = 77;
            int s2 = 96;
            int s3 = 99;
            int s4 = 66;
            int s5 = 92;
            int Total = s1 + s2+ s3+s4+s5;
            int Average = Total / 5;
            Console.WriteLine("Average is :"+Average);
            double Percentage = (Total / 100) * 100;
            Console.WriteLine("Percentage is: " + Percentage);

        }
    }
}
