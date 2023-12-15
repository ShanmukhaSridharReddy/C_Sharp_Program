using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class OddEven
    {
        public void CheckOddEven()
        {
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2 == 0)
            {
                Console.WriteLine("The Number is Even");
            }
            else
            {
                Console.WriteLine("The Number Is Odd");
            }
        }
    }
}
