using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class PrintArray
    {
        public static void GenericPrint(int[] array)
        {


            foreach (int a in array)
            {
                Console.WriteLine(a);

            }
        }
        public static void GenericPrint(double[] array)
        {
            foreach (double a in array)
            {
                Console.WriteLine(a);

            }
        }
        public static void GenericPrint(char[] array)
        {
            foreach (char a in array)
            {
                Console.WriteLine(a);

            }
        }
        public static void toprint<T>(T[] Array)
        {
            foreach (var t in Array) {
            Console.WriteLine(t);
            }
        }

    }
}
