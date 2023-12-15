using System;

namespace Constructor
{
    public class Employee
    {
       
        static void Main(string[] args)
        {
            EmployeeClass E1 = new EmployeeClass(6,"shanmukha",22);
            EmployeeClass E2 = new EmployeeClass (7, "sridhar", 23);
            Console.WriteLine("Employee Empid is : {0}", E1.getEmpId());
            Console.WriteLine("Employee Name is : {0}",E1.getEmpName());
            Console.WriteLine("Employee Age is : {0}",E1.getEmpAge());

            Console.WriteLine("Employee Empid is : {0}", E2.getEmpId());
            Console.WriteLine("Employee Name is : {0}", E2.getEmpName());
            Console.WriteLine("Employee Age is : {0}", E2.getEmpAge());
            
        }
    }

}
