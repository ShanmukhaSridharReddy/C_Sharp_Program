using System;
using System.Collections.Generic;
using System.Linq;

namespace DateAndTimeReview
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, };
            foreach( int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Divisible by 4");
            var div4 = list.Select(w => w % 4 == 0);
            foreach( var a in div4)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("Square of each number");
            var square = list.Select(a => a * a);
            foreach (var b in square)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();
            Console.WriteLine("find max value");
            
            Console.WriteLine(list.Max());
            


        }
    }
}
