using System;
using System.Collections.Generic;
using System.Text;

namespace SortArraysTraining
{
    static class ArrayFilters
    {
        public static void SortIntArrayAndDisplay(this int[] arr, SortDelegate del)
        {
            del.Invoke(arr);

            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(new string('-', 3));
        }
    }
}
