using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class PrimeOrNot
    {
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter Number");
            int n= int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= n; i++)
            {
                if(n%i==0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine("Its a prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
