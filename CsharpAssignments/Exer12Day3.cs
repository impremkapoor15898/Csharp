using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Exer12Day3
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
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
                Console.WriteLine($"{pair.Key} -> {pair.Value} times.");
        }
    }
}
