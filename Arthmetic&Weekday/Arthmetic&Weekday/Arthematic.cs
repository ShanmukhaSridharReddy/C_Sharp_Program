using System;
using System.Collections.Generic;
using System.Text;

namespace Arthmetic_Weekday
{
    public class Arthematic
    {
        public static void Aoperations()
        {
            Console.WriteLine("Enter a vlaue");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b value");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter symbol +,-,*,/,% ");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine(a+b);
                    break;
                    case "-":
                    Console.WriteLine(a-b);
                    break;
                    case "*":
                    Console.WriteLine(a*b);
                    break;
                    case "/":
                    Console.WriteLine(a/b);
                    break;
                    case "%":
                    Console.WriteLine(a%b);
                    break;
                default:
                    Console.WriteLine("enter valid symbol");
                    break;

            }
        }
    }
}
