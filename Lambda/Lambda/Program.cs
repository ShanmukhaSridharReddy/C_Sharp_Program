using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> s= new List<int>() { 8,5,6,4,7,9,3,2,1};
            Console.Write("Input:");
     
            foreach (int i in s)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();


            var age = s.Select(a => a > 1 && a < 7);
            foreach( var  ag in age)
            {
                Console.Write(ag);
            }
            Console.WriteLine();
            var squares = s.Select(a => a * a);
            Console.Write("Output:");
            foreach(int i in squares)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            List<int> div3 = s.FindAll(a => (a % 3) ==0);
            Console.Write("divide by 3:");
            foreach( var c in div3)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();

            Console.WriteLine("using Where");
            var where = s.Where(a => a % 2 == 0);
            foreach( var c in where)
            { 
                Console.Write(c+" "); 
            }
            Console.WriteLine();

            Console.WriteLine("using OrderBy");
            var order = s.OrderBy(x => x);
            foreach (int a in order)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();

            var desc = s.OrderByDescending(x => x);
            foreach ( int i in desc)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("using count");

            var count = s.Count(x => (x%2) ==0);
            Console.WriteLine(count);

            bool anyEven = s.Any(x => x % 2 == 0);
            Console.WriteLine(anyEven);

            Console.WriteLine("using sum");
            var total = s.Sum();
            Console.WriteLine("sum is : "+total);

            Console.WriteLine("using average");
            var avg = s.Average();
            Console.WriteLine("Average is : "+avg);

            Console.WriteLine("using min");
            var min = s.Min();
            Console.WriteLine("min is :" + min);

            Console.WriteLine("using max");
            var max = s.Max();
            Console.WriteLine("max is :" + max);

        }
    }
}
