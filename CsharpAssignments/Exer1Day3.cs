using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    struct Exer1Day3
    {
        public string name;
        public string sex;
        public float height;
        public float weight;

        public void getValues(string nam, string sex, float height, float weight)
        {
            name = nam;
            this.sex = sex;
            this.height = height;
            this.weight = weight;
        }
        public string display()
        {
            return $"Name:{name} \nSex:{sex}\nHeight:{height} cm\nWeight:{weight} kgs";

        }
    }
    class Exer1Day3Test
    {
        public static void Main()
        {
            Exer1Day3 u = new Exer1Day3();
            u.getValues("Abc", "Male", 180, 75);
            Console.WriteLine(u.display());
        }
    }
}
