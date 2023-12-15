using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoins
{
    public class SumOfNaturalNumbers
    {
        public static void sum()
        {
            int n = 5;
            int sum = 0;
            while (n > 0)
            {
                sum = sum + n;
                n--;
            }
            Console.WriteLine(sum);
        }
    }
}
