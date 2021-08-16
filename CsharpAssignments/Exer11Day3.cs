using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise
{
    class Exer11Day3
    {
        public static void Main()
        {
            int[] array = { 4, 2, 6, 4, 4, 1, 1, 3, 2 };
                int len = array.Length;
                for (int i = 0; i < len; i++)
                {
                    int count = 0;

                    for (int j = 0; j < len; j++)
                    {
                        if (array[i] == array[j])
                            count++;
                    }
                    if (count % 2 == 0)
                        Console.WriteLine( array[i]);
                }
             
           

        }
    }
}
