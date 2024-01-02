<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class Calculator
    {
        public static void calculatorOperation()
        {
            Console.WriteLine("Enter 1st number");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose which operation you want to perform \n 1.Addition \n 2.Substraction\n 3.Multiplication \n 4.Division\n 5.Modulo Division");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Addition is : " + (n1 + n2));
                    break;
                case 2: 
                    Console.WriteLine("Substraction is : "+(n1-n2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is : " + (n1 * n2));
                    break;
                case 4:
                    Console.WriteLine("Division is : " + (n1 / n2));
                    break;
                case 5:
                    Console.WriteLine("Modulo Division : "+(n1%n2));
                    break;
                default:
                    Console.WriteLine("Select options 1-5 only");
                    break;

            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class Calculator
    {
        public static void calculatorOperation()
        {
            Console.WriteLine("Enter 1st number");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose which operation you want to perform \n 1.Addition \n 2.Substraction\n 3.Multiplication \n 4.Division\n 5.Modulo Division");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Addition is : " + (n1 + n2));
                    break;
                case 2: 
                    Console.WriteLine("Substraction is : "+(n1-n2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is : " + (n1 * n2));
                    break;
                case 4:
                    Console.WriteLine("Division is : " + (n1 / n2));
                    break;
                case 5:
                    Console.WriteLine("Modulo Division : "+(n1%n2));
                    break;
                default:
                    Console.WriteLine("Select options 1-5 only");
                    break;

            }
        }
    }
}
>>>>>>> 04deadebb31232fe066a62176929eaa106a76b6b
