using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda
{
    public class Arrays
    {
        static void Main(string[] args)
        {
            int []array = {1,2,5,4,8};
            Console.WriteLine("input");
            foreach(int i in array)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            var squares = array.Select(a => a * 2);
            Console.WriteLine("output");
            foreach( var a in squares)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();

            //var div = array.FindAll (a => (a > 0);
            

        }
    }
}
