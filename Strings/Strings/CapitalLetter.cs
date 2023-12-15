using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class CapitalLetter
    {
        public static void FirstLetter() {
            String str = "hello";
            String s = "";
            for( int i = 0; i < str.Length; i++ ) 
            {
                if( i == 0)
                {
                    s=s+str.Substring(0,1).ToUpper();
                }
                else
                    s=s+str.Substring(i).ToLower();
            }
            Console.WriteLine( s );
        }
    }
}
