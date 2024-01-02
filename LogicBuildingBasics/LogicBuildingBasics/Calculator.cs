using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuildingBasics
{
    public class Calculator
    {
        public static void Cal()
        {
            Console.WriteLine("enter a number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int n2 = int.Parse(Console.ReadLine());
            int result;
            Console.WriteLine("select which operation you want");
            Console.WriteLine("1 Addition\n 2 Substraction\n 3 Multiplication \n 4 Division \n 5 ModuloDivision");
            int option = int.Parse(Console.ReadLine());
            
            
                switch (option)
                {
                    case 1:
                        result = n1 + n2;
                        Console.WriteLine("The Addition is : " + result);
                        break;
                    case 2:
                        result = n1 - n2;
                        Console.WriteLine(" Substraction is : " + result);
                        break;
                    case 3:
                        result = n1 * n2;
                        Console.WriteLine("Multiplication is :" + result);
                        break;
                    case 4:
                        result = n1 / n2;
                        break;
                    case 5:
                        result = n1 % n2;
                        Console.WriteLine("Modulodivision is :" + result);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
        } 
    }
}
