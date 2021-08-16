using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public interface Car
    {
        void read(string name);
        void display(string name);

    }

    class Exer4Day3:Car
    {
        public void read(string name)
        {
            Console.WriteLine($"The car name is {name}");
        }
        public void display(string name)
        {
            Console.WriteLine($"The cost of {name} is 4000000");
        }
    }
    class Exer4Day3test
    {
       public static void Main()
        {
            Exer4Day3 e = new Exer4Day3();
            e.read("xyz");
            e.display("xyz");

        }
    }

}
