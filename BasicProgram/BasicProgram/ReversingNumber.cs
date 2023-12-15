using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class ReversingNumber
    {
        public static void ReverseAnumber()
        {
            int n = 54321;
            int r, rev = 0;
            while(n>0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            Console.WriteLine(rev);
        }
    }
}
