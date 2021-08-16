using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise
{
    class Exer8Day3
    {
        public static void Main()
        {
            Stack<int> s = new Stack<int>();
            Console.WriteLine("Enter the total number of elements");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {N} elements");
            foreach (int i in Enumerable.Range(1, N)) 
            {
                s.Push(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("The values entered in reverse order");
            for(int i = 0;i < N;i++)
            {
                Console.WriteLine(s.Pop());
            }
        }

     
    }
}
