using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class SpeedOfTrain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter distance in KM");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Speed in Hours");
            double time = double.Parse(Console.ReadLine());
            double speed = distance / time;

            Console.WriteLine("The speed of the train is " + speed + " km/h");
        }
    }
}
