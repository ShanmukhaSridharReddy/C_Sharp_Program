using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class MultiplesOf17
    {
        public static void MultiplesLessThan100()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i%17 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
