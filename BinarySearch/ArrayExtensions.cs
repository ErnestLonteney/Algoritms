using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch.Extensions
{
    static class ArrayExtensions
    {
        public static int SimpleSearch(this int[] arr, int target) // O(n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }

            return -1;
        }

        public static int BinarySearch(this int[] arr, int target)    // O(log n)
        {
            int leftIndex = 0;
            int rightIndex = arr.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;

                if (arr[middleIndex] == target)
                    return middleIndex;
                else
                    if (target > arr[middleIndex])
                        leftIndex = middleIndex + 1;
                    else
                        rightIndex = middleIndex - 1;
            }

            return -1;
        }

        public static void DisplayNumber(this int number)
        {
            Console.WriteLine($"Number={number}");
        }
    }
}
