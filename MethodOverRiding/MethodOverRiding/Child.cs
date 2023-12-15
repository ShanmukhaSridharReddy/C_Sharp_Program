using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverRiding
{
    public class Child : Parent
    {
        public override void print()
        {
            Console.WriteLine("this is Child Class");
        }
    }
}
