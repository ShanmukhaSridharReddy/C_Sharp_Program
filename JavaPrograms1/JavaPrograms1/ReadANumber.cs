using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class ReadANumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((n=n-1) + " " + (n=n+2));
        }
    }
}
