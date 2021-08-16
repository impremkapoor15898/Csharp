using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise
{
    class Exer10Day3
    {
        public static void Main()
        {
            List<int> l = new List<int>();
            Console.WriteLine("Enter the numbers");
            while(true)
            {
                string str = Console.ReadLine();
                if (str == string.Empty)
                {
                    break;
                }
                else
                {
                    int num = int.Parse(str);
                    l.Add(num);
                }
            }
            Console.WriteLine("The updated list is:");
            int count = l.Count;
            int c = 0;
            int i = 0;
            while (c < count)
            {

                for (; i < count; i++)
                {
                    if (l.ElementAt(i) < 0)
                    {
                        l.RemoveAt(i);
                        count--;
                        c=i;
                        break;
                    }
                    else
                        continue;
                }
                c++;
            }
            if (l.ElementAt(0) < 0)
                l.RemoveAt(0);
            foreach (int num in l)
            {
                Console.WriteLine(num);
            }
        }
    }
}
