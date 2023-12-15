using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class TrainSpeed
    {
        static void Main(string[] args)
        {
            double distance = 350.0;
            double minutes = 180.0;
            double timeInHours = minutes / 60.0;
            double speed = distance / timeInHours;
            Console.WriteLine("The speed of the train is : "+speed+"Km/h");
        }
    }
}
