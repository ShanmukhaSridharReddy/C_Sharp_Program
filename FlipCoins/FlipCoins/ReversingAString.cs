using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoins
{
    public class ReversingAString
    {
        public static void ReverseAString() 
        {
            Console.WriteLine("Enter any word");
            string str = Console.ReadLine();
            String rev = " ";
            for (int i = 0; i < str.Length; i++) {
                rev = str[i] + rev;
            }
            Console.WriteLine(rev);

        }
    }
}
