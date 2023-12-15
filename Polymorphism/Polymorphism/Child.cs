using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Child : MethodOverriding
    {
        public void draw(int a)
        {
            double perimeter = 2 * 3.14 * a;
            Console.WriteLine(perimeter);

        }

    }

}
