using System;
using System.Collections.Generic;
using System.Text;

namespace JavaPrograms1
{
    public class Minutes
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Minutes to Convert:");
            int minutes = int.Parse(Console.ReadLine());
            int seconds = minutes * 60;
            Console.WriteLine(seconds+" seconds");
        }
    }
}
