using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public abstract class Employee
    {
        /// <summary>
        /// Abstract class for Employee having the details of ID,Name,Address and basicPay.
        /// </summary>
         protected int EmpID { get; set; } 
         protected string EmpName { get; set; }
         protected string address { get; set; }
         protected float basePay { get; set; }
        public Employee()
        {
            this.EmpID = 0;
            this.EmpName = "NULL";
            this.address = "NULL";
            this.basePay = 0;
        }
        public Employee(int EmployeeID,string EmployeeName,string Address,float BasicPay)
        {
            this.EmpID = EmployeeID;
           this.EmpName = EmployeeName;
            this.address = Address;
            this.basePay = BasicPay;
        }
        public abstract string calculateSalary();

    }

}
