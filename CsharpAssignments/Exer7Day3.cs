using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Exer7Day3
    {
        public static void Main()
        {
            List<int> A = new List<int>();
            Console.WriteLine("Enter the positive numbers");
            while(true)
            {
                string str = Console.ReadLine();
                if (str==string.Empty)
                    break;
                else
                {
                    int num = int.Parse(str); 
                    if(num>0)
                    {
                        A.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("You have entered a non positive number." +
                            "Hence, not accepted");
                    }
                }
            }
            int i= 0;
            int sum = 0;
            foreach (int a in A)
            {
                sum = sum + a;
                i++;
            }
            float avg =(sum) / i;
            Console.WriteLine($"Sum={sum}\n" +
                $"Average={avg}"); 
                
         }
    }
}
