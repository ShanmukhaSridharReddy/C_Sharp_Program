using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAndLastWord
{
    public class ExchangeTwoIntegers
    {
        public static void TwoIntegers()
        {
            int a = 10;
            int b = 30;
            a = a+b;
            b = a-b;
            a = a - b;

            Console.WriteLine(a+" "+b);
        }
    }
}
