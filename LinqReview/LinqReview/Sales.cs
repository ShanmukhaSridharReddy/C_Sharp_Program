using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace LinqReview
{
    public class Sales
    {
        public string Name { get; set; }
        public int Transaction { get; set; }
        public int NoofItems { get; set; }

        public static List<Sales> GetSales()
        {
            List<Sales> sale = new List<Sales>()
                {
                    new Sales()  { Name= "soap" , Transaction = 5 , NoofItems= 7 },
                    new Sales() { Name = "soap" , Transaction = 6 , NoofItems = 8},
                    new Sales() { Name = "shampoo" , Transaction= 4, NoofItems = 4},
                    new Sales() { Name = "paste" , Transaction= 8, NoofItems = 6},
                    new Sales() { Name = "paste" , Transaction= 7, NoofItems = 8},
                    new Sales() { Name = "shampoo" , Transaction= 6, NoofItems = 7},
                    new Sales() { Name = "paste" , Transaction = 7, NoofItems = 9}

                };
            return sale;

        }
        static void Main(string[] args)
        {

        }
    }
}
