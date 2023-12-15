using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms2
{
    public class Factors
    {
        public static void factor()
        {
            Console.WriteLine("Enter a number: ");
            int n= int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if (n %i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
