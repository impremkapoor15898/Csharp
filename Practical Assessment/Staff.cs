using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Staff:Employee
    {
        public string title;
        public float sal;
        public float HRA;
        public Staff(int EmpID, string EmpName, string address, float basePay, string Title) : base(EmpID, EmpName, address, basePay)
        {
            this.title = Title;
        }
        public override string calculateSalary()    ///calculating hra for staff and calculating salary
        {
            this.HRA = (float)(18.0 / 100) * this.basePay;
            this.sal = this.basePay + this.HRA;
            return $"The salary of {this.EmpName} is Rs. {this.sal}";
        }
        public override string ToString()                    ///Method overriding
        {
            return $"Employee ID:{this.EmpID}\n" +
                $"Employee Name:{this.EmpName}";
        }
        
        public void ValidateEmpID()
        {
            if (this.EmpID < 0 || this.EmpID > 30000)
            {
                throw (new InvalidEmpID("Employee ID is invalid"));
            }

        }
        public class InvalidEmpID : Exception
        {
            public InvalidEmpID(string message) : base(message)
            {

            }
        }
        public void ValidateBasePay()
        {
            if (this.basePay < 0)
            {
                throw (new InvalidBasePay("Base Salary is invalid"));
            }

        }
        public class InvalidBasePay : Exception
        {
            public InvalidBasePay(string message) : base(message)
            {

            }
        }
    }
}
