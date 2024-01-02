using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace LogicBuildingBasics
{
    public class Grade
    {
        public static void DisplayGrade()
        {
            Console.WriteLine("Enter grade in UpperCase");
            char grade= char.Parse(Console.ReadLine());
            switch (grade)
            {
                case 'S':
                    Console.WriteLine("SUPER");
                    break;
                case 'A': Console.WriteLine("VERY GOOD");
                    break;
                case 'B':
                    Console.WriteLine("FAIR");
                    break;
                case 'Y':
                    Console.WriteLine("ABSENT");
                    break;
                case 'F':
                    Console.WriteLine("FAIL");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
