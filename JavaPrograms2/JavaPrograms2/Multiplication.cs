using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms2
{
    public class Multiplication
    {
        public static void mul()
        {
            Console.WriteLine("Enter a Number");
            int n= int.Parse(Console.ReadLine());
            int t = 0;
            for (int i=1; i <= 10; i++)
            {
                t = t + n;
                Console.WriteLine(n+"*"+i+"="+t);
            }
        }
    }
}
