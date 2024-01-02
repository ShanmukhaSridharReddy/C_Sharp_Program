using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class SumOfDigit
    {
        public static void DigitSum()
        {
            Console.WriteLine("Enter Digit");
            int num = int.Parse(Console.ReadLine());
            int sum = 0,r;
            while(num > 0)
            {
                r= num%10;
                sum += r;
                num = num/10;

            }
            Console.WriteLine(sum);
        }
    }
}
