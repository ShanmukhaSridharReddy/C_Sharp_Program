using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoins
{
    public class FlipCoin
    {
        public static void CoinFlip()
        {
            int head = 0;
            int tail = 0;
            Random rand = new Random();
            int result = rand.Next(2);
           
                if (result == 0)
                {
                    Console.WriteLine("Heads");
                    head++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tail++;
                }
            if(head >=20 )
            {
                Console.WriteLine("HeadWins");

            }
            else
            {
                Console.WriteLine("TailWins");
            }

        }
    }
}
