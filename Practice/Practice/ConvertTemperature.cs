using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class ConvertTemperature
    {
        public static void Temperature()
        {
            Console.WriteLine("Enter Temperature : ");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("select \n 1.Fahrenheit too Celsius \n 2.Celsius to Fahrenheit ");
            int choice = int.Parse(Console.ReadLine());
          
            switch (choice)
            {
                case 1:
                    double res = (temp - 32) *5 / 9;
                    Console.WriteLine(res);
                    break;
                case 2:
                    Console.WriteLine((temp  * 9 / 5)+ 32);
                    break;
                default:
                    Console.WriteLine(" Invalid enter number 1 or 2 ");
                    break;
            }
        }
    }

}
