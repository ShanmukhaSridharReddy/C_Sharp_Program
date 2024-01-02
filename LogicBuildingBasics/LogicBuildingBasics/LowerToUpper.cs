using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class LowerToUpper
    {
        public static void ViceVersa()
        {
            Console.WriteLine("Enter a letter");
            char a = Convert.ToChar(Console.ReadLine());
            int i = (int)a;
            if (a>=65 && a<=90)
            {
                Console.WriteLine("the character is : "+char.ToLower(a));
            }
            else if (a>=97 && a<=122)
            {
                Console.WriteLine("The Character is : "+char.ToUpper(a));
            }
        }
    }
}
