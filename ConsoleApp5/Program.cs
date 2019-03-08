using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int[] array = new int[] { 2, 1, 4, 3, 5, 0, 7, 6, 8, 9 };

        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter number to find ");
            int search = Int32.Parse(Console.ReadLine());
            object BinaryS(int[] array, int key)
            {
                int min = 0;
                int max = array.Length - 1;
                while (min <= max)
                {
                    int mid = (min + max) / 2;
                    if (key == array[mid])
                    {
                        return mid;
                    }
                    else if (key < array[mid])
                    {
                        max = mid - 1;
                    }
                    else if (key > array[mid])
                    {
                        min = mid + 1;
                    }

                }
                return "Int not found";

            }
            array.Insert_sort();
            Console.Read();
        }
    }
}
