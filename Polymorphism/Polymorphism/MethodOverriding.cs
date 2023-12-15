using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class MethodOverriding
    {
        public void draw(int r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine(area);
        }
    }
}
