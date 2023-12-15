using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class ReadPositiveNumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any Number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(-(n));
        }
    }
}
