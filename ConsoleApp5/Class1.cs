using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class InsertionSort
    {
        static int[] array = new int[] { 2, 1, 4, 3, 5, 0, 7, 6, 8, 9 };
        public InsertionSort()
        {

            Insert_sort();

        }
        public static void Insert_sort()
        {
            int tmp;
            
            //O^n 
            for (int i = 0; i < array.Length; i++)
            {
                for (int l = 0; l < array.Length; l++)
                {
                    if (array[i] < array[l])
                    {
                        tmp = array[l];
                        array[l] = array[i];
                        array[i] = tmp;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }
            Console.Read();
        }
    }
 




}
