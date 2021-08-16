using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Exer9Day3
    {
        public static void Main()
        {
            List<int> l = new List<int>();
            Console.WriteLine("Enter the positive numbers");
            while (true)
            {
                string str = Console.ReadLine();
                if (str == string.Empty)
                {
                    break;
                }
                else
                {
                    int num = int.Parse(str);
                    if(num>0)
                    {
                        l.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("You have entered a non positive integer");
                    }
                }
            }
            l.Sort();
            int count=l.Count;
            foreach (int i in l) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
