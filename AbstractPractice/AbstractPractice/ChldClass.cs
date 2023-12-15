using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
     class ChldClass : ParentClass, Family
    {
        public override void showname()
        {
            Console.WriteLine(Getname());
            Console.WriteLine(age);
        }

        public void showFamilyMembers()
        {

        }
        public void hideFamilyMembers()
        {

        }

    }
}
