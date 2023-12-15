using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace JavaPrograms1
{
    public class ConvertRupees
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rupees");
            double Rupees = double.Parse(Console.ReadLine());
            double Dollars = Rupees/72;
            Console.WriteLine(Dollars+" USD");
        }
    }
}
