using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class EmployeeClass
    {
       private int EmpId;
        string EmpName;
        int EmpAge;

        public EmployeeClass(int empId, string empName, int empAge)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpAge = empAge;
        }
        public int getEmpId()
        {
            return this.EmpId;
        }
        public string getEmpName()
        {
            return this.EmpName;
        }
        public int getEmpAge()
        {
            return this.EmpAge;
        }
    }
}
