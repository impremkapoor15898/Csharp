using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    /// <summary>
    /// Write a program using a class that get information about employee rollno, name, address, pin 
    ///code, phone number, gross salary and pf.Display the net salary(ie gross less pf) and calculate
    ///grade base on net salary.The grades are
    ///Grade-‘A’ sal>10000
    ///Grade-‘B’ sal>5000
    ///Grade-‘C’ sal<5000
    /// </summary>
    class Exer2Day3
    {
        //int rollno;
        //string name;
        //string address;
        //int pincode;
        //int phoneno;
        //float grossSal;
        //float pf;
        int rollno { get; set; }
        string name { get; set; }
        string address { get; set; }
        int pincode { get; set; }
        int phoneno { get; set; }
        float grossSal { get; set; }
        float pf { get; set; }
   
        float netSal;
      
        public void get(int rollno, string name,string address, int pincode, int phoneno,float gross, float PF)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
            this.pincode = pincode;
            this.phoneno = phoneno;
            this.grossSal = gross;
            this.pf = PF;
        }

        public string displaySal()
        {
            this.netSal = this.grossSal - this.pf;
            if(this.netSal>10000)
            {
                return $"The net salaray is {this.netSal}\n" +
                    $"Grade A";
            }
            else if(this.netSal>5000)
            {
                return $"The net salaray is {this.netSal}\n" +
                    $"Grade B";
            }
         else
                return $"The net salaray is {this.netSal}\n" +
                    $"Grade C";
        }


    }
    class Exer2Day3Test
    {
       public static void Main()
        {
            Exer2Day3 e = new Exer2Day3();
            e.get(1,"abc","xyz",123456,1234567891,50000, 1500);
            Console.WriteLine(e.displaySal());

           

        }
    }

}
