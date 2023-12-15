using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class Meters
    {
        static void Main()
        {
            Console.WriteLine("Enter Meters to Convert:");
            double meter = int.Parse(Console.ReadLine());
            double kilometer = meter / 1000;
            Console.WriteLine(kilometer+" KiloMeters");
        }
    }
}
