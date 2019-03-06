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
            
            new InsertionSort();
            public static object BinaryS(int search)
            {
                Console.Write("Enter number to find ");
                search = Int32.Parse(Console.ReadLine());
                int min = 0;
                int max = array.Length - 1;
                int key = 0;
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

                }
            }


            


        }
        
    }
}
