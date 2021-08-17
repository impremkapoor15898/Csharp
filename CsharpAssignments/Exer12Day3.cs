using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public abstract class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string address { get; set; }
        public float basePay { get; set; }
        public abstract string calculateSalary();

    }
    class TechnicalEmployee : Employee
    {
        public List<string> technicalSkill { get; set; }
        public float sal;
        public float HRA;
        public override string calculateSalary()
        {
            this.HRA = (12 / 100) * this.basePay;
            this.sal = this.basePay + this.HRA;
            return $"The salary of {this.EmpName} is Rs. {this.sal}";
        }
        public override string ToString()
        {
            return $"Employee ID:{this.EmpID}" +
                $"Employee Name:{this.EmpName}";
        }

    }
