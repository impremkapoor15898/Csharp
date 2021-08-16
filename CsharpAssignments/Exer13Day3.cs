using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Exer13Day3
    {
        static void Main(string[] args)
        {
            int[] array = { 2,2,1,2,2,1 };
            int len = array.Length;
            int flag = 0;
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                // When the key is not found, "count" will be initialized to 0
                dict.TryGetValue(value, out int count);
                dict[value] = count + 1;
            }
            foreach (var pair in dict)
                if ((pair.Value) >= ((len / 2) + 1))
                {
                    Console.WriteLine($"{pair.Key} is the majorant");
                    Console.WriteLine($"{pair.Key} -> {pair.Value} times.");
                    flag = 1;

                }

            if (flag == 0)
            {
                Console.WriteLine($"The majorant doesn't exist");
            }
        }

        }
    }
