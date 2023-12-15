using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAndLastWord
{
    public class LowerCase
    {
        public static void FirstAndLastLower()
        {
            string str = "helloworld";
            Char[] c = str.ToCharArray();
            for (int i=0; i<c.Length; i++)
            {
                if ( i != 0 && i != c.Length-1)
                {
                    c[i] = (char)(c[i] - 32);
                   
                }
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
        

    }
}
