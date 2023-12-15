using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class MaxInteger
    {
        public static T FindGreatest<T>(T a, T b, T c, Func<T, T, bool> comparer)
        {
            if (comparer(a, b) && comparer(a, c))
            {
                return a;
            }
            else if (comparer(b, a) && comparer(b, c))
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
