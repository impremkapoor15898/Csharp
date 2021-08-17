using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class TechnicalEmployee:Employee
    {
        public string[] technicalSkill { get; set; }
        public float sal;
        public float HRA;

        public TechnicalEmployee(int EmployeeID, string EmployeeName, string Address, float BasicPay, string[] TechnicalSkill):base(EmployeeID, EmployeeName, Address, BasicPay)
        {
            this.technicalSkill = TechnicalSkill;
        }
        public override string calculateSalary()                 ///Abstract method and calcuating hra and salary of tech emp.
        {
            this.HRA = (float)(12.0 / 100) * this.basePay;
            this.sal = this.basePay + this.HRA;
            return $"The salary of {this.EmpName} is Rs. {this.sal}";
        }
        public override string ToString()     ///Method overriding 
        {
            return $"Employee ID:{this.EmpID}\n" +
                $"Employee Name:{this.EmpName}";
        }
        
        public void ValidateEmpID()
        {
            if (this.EmpID < 0 || this.EmpID>30000)
            {
                throw (new InvalidEmpID("Employee ID is invalid")); ///using if and throw blocks to find and through errors so that user can give correct input
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
            if (this.basePay < 0 )
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
    class UsingPeople
    {
        public static void Main(string[] args)/// getting the details of technical employee
        {
            TechnicalEmployee t= new TechnicalEmployee(259, "Pras", "Ant", 20000,new string[] { "C", "C++", "C#" });

           
            try
            {
                t.ValidateEmpID();
                Console.WriteLine(t.ToString());
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                t.ValidateBasePay();
                Console.WriteLine(t.calculateSalary());
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Staff s = new Staff(269, "Rah", "Ula", 25000, "Security"); ///getting the details of staff employee

            try
            {
                s.ValidateEmpID();
                Console.WriteLine(s.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            try
            {
                s.ValidateBasePay();
                Console.WriteLine(s.calculateSalary());
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }
}
