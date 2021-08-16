using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Exer3Day3
    {
       /// <summary>
       /// Create a base class to take regno and name of students. Using inheritance, write a pgm that will 
       /// take marks as input from the student.Provide two branches science and commerce.If the
       ///student enters science then get the marks of physics, chemistry and math.If the student enters
       /// commerce, get the marks for economics, accounts and banking.Then calculate the average of
       /// the three subjects. The output should display regno, name, details of marks subject wise and the
       ///average of marks.
       /// </summary>
        int regno;
        string name;
        public Exer3Day3(int regno,string name)
        {
            this.regno = regno;
            this.name = name;
        }
        public override string ToString()
        {
            return $"Regno:{this.regno}\n" +
                $"Name:{this.name}";
        }
    }
    class science : Exer3Day3
    {
        float phy;
        float chem;
        float maths;
        float avg;
        public science(int regno,string name,float phy,float chem,float maths):base(regno,name)
        {
            this.phy = phy;
            this.chem = chem;
            this.maths = maths;
        }
        public override string ToString()
        {
            this.avg = (phy + maths + chem) / 3;
            return base.ToString() + $"\nMarks obtained:\n" +
                $"Physics:{this.phy}\nChemistry:{this.chem}\nMaths:{this.maths}\n" +
                $"With an average of {this.avg}";
        }




    }
    class commerce : Exer3Day3
    {
        float economics;
        float accounts;
        float banking;
        float avg;
        public commerce(int regno, string name, float economics, float accounts, float banking) : base(regno, name)
        {
            this.economics = economics;
            this.accounts = accounts;
            this.banking = banking;
        }
        public override string ToString()
        {
            this.avg = (economics + accounts + banking) / 3;
            return base.ToString() + $"\nMarks obtained:\n" +
                $"Economics:{this.economics}\nAccounts:{this.accounts}\nBanking:{this.banking}\n" +
                $"With an average of {this.avg}";
        }
    }
    class Exer3Day3Test
    {
        public static void Main()
        {
            science s = new science(10,"Abc", 90, 85, 95);
            commerce c = new commerce(20, "Xyz", 95, 85, 88);
            Console.WriteLine(s.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}
