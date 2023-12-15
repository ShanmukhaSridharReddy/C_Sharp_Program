using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class Vote
    {
        public static void VoteEligibility()
        {
            Console.WriteLine("enter age");
            int n = int.Parse(Console.ReadLine());
            if( n >= 18)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }
}
