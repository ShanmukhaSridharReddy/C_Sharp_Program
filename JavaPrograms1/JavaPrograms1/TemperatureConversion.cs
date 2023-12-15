using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    internal class TemperatureConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Celcius");
            double Celcius = double.Parse(Console.ReadLine());
            double FarenHeat = (Celcius * 9 / 2) + 32;
            Console.WriteLine("Farenheat : "+FarenHeat);
        }
    }
}
