using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class KiloMeters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter KiloMeters to Convert");
            double Kilometers = Convert.ToDouble(Console.ReadLine());
            double meters = Kilometers / 1000;
            Console.WriteLine(meters+" meters");
        }
    }
}
