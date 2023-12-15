using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace LinQList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] Array = { 10,20,30,40,50,60,70,80 };
            var method  = Array.Where(a => a > 60);
            var query = (from a in Array where a > 30 select a);
            Console.WriteLine("Methods");
            foreach (var item in method) Console.WriteLine(method);
            Console.WriteLine("Query");
            foreach(var item in query) Console.WriteLine(item);
            var method1 = Array.Distinct();
            var query1 = (from a in Array select a).Distinct();
            Console.WriteLine("Methods");
            foreach (var item in method1) Console.WriteLine(method1);
            Console.WriteLine("query");
            foreach (var item in query1) Console.WriteLine(query1);
           

        }
    }
}
