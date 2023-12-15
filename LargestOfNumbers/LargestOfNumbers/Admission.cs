using System;
using System.Collections.Generic;
using System.Text;

namespace LargestOfNumbers
{
    public class Admission
    {
        public static void AdmissionEligilibility()
        {
            Console.WriteLine("Enter Maths marks:");
            int mathematics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter physics marks:");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter chemistry marks:");
            int chemistry = int.Parse(Console.ReadLine());
            if(mathematics >= 65)
            {
                if(physics >= 55)
                {
                    if (chemistry >= 50)
                    {
                        if((mathematics+physics+chemistry) >=180 || (mathematics+physics) >=140 || (chemistry+chemistry) >=140)
                        {
                            Console.WriteLine(" The Candidate is eligible for admission");
                        }
                        else
                        {
                            Console.WriteLine("The candidate is not eligible");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The candidate is not eligible");
                    }
                }
                else
                {
                    Console.WriteLine("The candidate is not eligible");
                }
            }
            else
            {
                Console.WriteLine("The candidate is not eligible");
            }
        }
    }
}
