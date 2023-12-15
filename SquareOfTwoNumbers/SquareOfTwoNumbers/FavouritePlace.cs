using System;
using System.Collections.Generic;
using System.Text;

namespace SquareOfTwoNumbers
{
    public class FavouritePlace
    {
        public static void place()
        {
            Console.WriteLine("Enter a place name:");
            String str = Console.ReadLine();
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
        }
    }
}
