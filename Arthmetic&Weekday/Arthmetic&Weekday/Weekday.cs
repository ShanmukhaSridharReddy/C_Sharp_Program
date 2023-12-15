using System;
using System.Collections.Generic;
using System.Text;

namespace Arthmetic_Weekday
{
    public class Weekday
    {
        public static void week()
        {
            Console.WriteLine("Enter numbers between 1 to7 ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Satursday");
                    break;
                default:
                    Console.WriteLine("enter valid number");
                    break;
            }
        }
    }
}
