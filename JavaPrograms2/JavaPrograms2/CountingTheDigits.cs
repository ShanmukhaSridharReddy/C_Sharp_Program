using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms2
{
    public class CountingTheDigits
    {
        public static void digitCount()
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while(num>0 )
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
