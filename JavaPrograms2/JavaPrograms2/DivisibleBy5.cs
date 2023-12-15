using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JavaPrograms2
{
    public class DivisibleBy5
    {
        public static void divisible()
        {
            Console.WriteLine("Enter M value");
            int m= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter N value");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
             for( int i=m; i<=n; i++ )
            {
                if (i % 5 == 0)
                    count++;
                    
            }
            Console.WriteLine(count);
        }
    }
}
