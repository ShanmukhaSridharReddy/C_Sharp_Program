using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysReview
{
    public class ArrayDeletion
    {
        
        public static void Array()
        {

            int[] intarr = { 1, 2, 3, 5, 8, 6 };
            double[] doublearr = { 1.5, 2.2, 45.6, 6.6 };
            char[] chararr = { 'a', 'b', 'c', };
            
            List<int> intList = intarr.ToList<int>();
            intList.RemoveAt(2);
            intarr = intList.ToArray();
            foreach(int i in intList)
            {
                Console.WriteLine(i);
            }

        }
        
        
}
    
}
