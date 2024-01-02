using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class MovieTickets
    {
        public static void tickets()
        {
            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Movie time");
            int movieTime= int.Parse(Console.ReadLine());
            double BasePrice = 100.00;
            double ChildDiscount = 20.0;
            double SeniorDiscount = 30.0;
            double MatineeDiscount = 10.0;

            double discount = 0;
            if( age < 12)
            {
                discount = discount + ChildDiscount;
            }
                    
            else if( age >= 65)
            {
                discount = discount + SeniorDiscount;
            }

            if (movieTime < 1700)
            {
                discount += MatineeDiscount;
            }
            double ticketPrice = Math.Max(BasePrice - discount, 0);
            // Console.WriteLine($"The ticket price is: ${ticketPrice:F2}");
            Console.WriteLine("ticket price is : " + ticketPrice);
        }
    }
}
