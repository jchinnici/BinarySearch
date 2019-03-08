using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    static class Binary
    {
        public static object BinaryS(int[] array, int search)
        {
            Console.Write("Enter number to find ");
            search = Int32.Parse(Console.ReadLine());
            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (search == array[mid])
                {
                    return mid;
                }
                else if (search < array[mid])
                {
                    max = mid - 1;
                }
                else if (search > array[mid])
                {
                    min = mid + 1;
                }

            }
            return "Int not found";
        }
    }
}
