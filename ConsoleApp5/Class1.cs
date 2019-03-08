using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    static class InsertionSort
    {
        
        public static int[] Insert_sort(this int[] array)
        {
            int tmp;
            
            //O^n2
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
            return array;
        }
    }
 




}
