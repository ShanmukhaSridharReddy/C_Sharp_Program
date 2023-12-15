using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysReview
{
    public class SwapTwonumbers
    {
        public static void SwapNumbers()
        {
            int a = 2;
            int b = 3;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a + " " + b);
        }
    }
}
