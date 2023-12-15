using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class PTR
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter principle amount:");
            double principle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Interest:");
            double interest = double.Parse(Console.ReadLine());
            //: total amount = principle + (principle * interest / 100).
            double totalamount = principle + (principle * interest / 100);
            Console.WriteLine(totalamount);
        }
    }
}
