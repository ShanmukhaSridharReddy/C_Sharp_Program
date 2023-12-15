using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class PrivateArray<T>
    {
        private T[] inputArray;
        public PrivateArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void toprint()
        {
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
