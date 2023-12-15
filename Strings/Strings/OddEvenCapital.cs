using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public  class OddEvenCapital
    {
        public static void OddEven()
        {
            String str = "helloworld";
            String s = "";
            for( int i=0; i<str.Length;i++ )
            {
                if( i%2  == 0)
                {
                    s = s + str. Substring(i).ToUpper();
                }
                else
                {
                    s= s+ str. Substring(i).ToLower();
                }
            }
            Console.WriteLine( s );
        }
    }
}
