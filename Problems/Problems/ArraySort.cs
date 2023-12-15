using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class ArraySort
    {
        
        public static void sort()
        {
            int[] n = { 1, 5, 8, 6, 3, 2, 4, 9 };


            for (int i = 0; i < n.Length; i++)
            {
                for(int j=0; j< n.Length; j++)
                {
                    if (n[i] < n[j])
                    {
                        int temp = n[i];
                        n[i] = n[j];
                        n[j] = temp;
                    }
                }
            }
            for( int k=0;k<n.Length;k++)
            {
                Console.WriteLine(n[k]);
            }
        }
         
    }
}
