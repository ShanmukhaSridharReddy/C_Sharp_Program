using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class SumOfTwoBinaryNumbers
    {
        public static void SumOfBinary()
        {
            int i = 0; int carry = 0;
            int[] sum = new int[20];
            Console.WriteLine("Enter 1st Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int b = int.Parse(Console.ReadLine());
            
            while(a!=0 || b != 0)
            {
                sum[i++] = ((a%10+b%10+carry)%2);
                carry= ((a%10+b%10+carry)/2);
                a = a / 10;
                b = b / 10;
            }
            if(carry != 0)
            {
                sum[i]= carry;
                i++;
            }
            Console.WriteLine("sum of two binary Numbers");
            while (i>=0)
            {
                Console.WriteLine(sum[i]); 
                i--;
            }

        }
    }
}
