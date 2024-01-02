using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class Palindrome
    {
        public static void PalindromeNot()
        {
            int n = 12321;
            int rel = n;
            int rev = 0, r;
            while ( n>0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            if (rel == rev)
                Console.WriteLine("Its a palindrame");
        }
    }
}
