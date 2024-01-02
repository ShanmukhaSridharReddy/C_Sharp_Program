using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class ReverseOfANumber
    {
        public static void NumberReversal()
        {
            int n = 12345;
            int rev = 0, r;
            while (n > 0)
            {
                r = n % 10;
                rev = rev*10 + r;
                n = n / 10;
            }
            Console.WriteLine(rev);
        }
    }
}
