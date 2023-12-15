using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Employee
    {
        public int EmpId;
        public string Name;
        public int Salary;
        public double GrossPay;
        public double TaxDeduction = 0.1;
        double netSalary;
        public Employee(int empid, string name, double grosspay)
        {
            this.EmpId = empid;
            this.Name = name;
            this.GrossPay = grosspay;
        }
        void calculateSalary()
        {
            if(GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your salary is : {0} ", netSalary);
            }
            else
            {
                Console.WriteLine("Your Salary is : {0}",GrossPay);
            }
            
        }
        public void showEmployeeDetails()
        {
            Console.WriteLine("Employee ID is : {0}",this.EmpId);
            Console.WriteLine("Employee Name is : {0}",this.Name);
            this.calculateSalary();
        }
    }
}
