namespace Arrays
{
    internal class Program
    {
        static int FindMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static int FindMin(int[] arr) // O(n-1)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        static int CalculateAverage(int[] arr) // O(n + 1)
        {
            int sum = SumOfNumbers(arr);

            return sum / arr.Length;
        }

        static int CountEvenNumber(int[] arr) // O(n)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    count++;
            }

            return count;
        }

        static int SumOfNumbers(int[] arr) // O(n)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }


        static int GetMinElementIndex(int[] arr, int startIndex)
        {
            int minIndex = startIndex;

            for (int i = startIndex; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        static void SortArray(ref int[] arr) // O(n^2)
        {
            int[] result = new int[arr.Length]; // 435345

            for (int i = 0; i < arr.Length; i++)
            {
                int minElementIndex = GetMinElementIndex(arr, 0);
                int minElement = arr[minElementIndex];
                arr[minElementIndex] = int.MaxValue;
                result[i] = minElement;
            }

            arr = result; // replaced address of the array with the address of the sorted array
        }

        // Selection sort algorithm
        static void SortArray2(int[] arr) // O(n^2) but without additional memory allocation
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minElementIndex = GetMinElementIndex(arr, i);
                if (i != minElementIndex)
                {
                    var buf = arr[i];
                    arr[i] = arr[minElementIndex]; 
                    arr[minElementIndex] = buf;
                }
            }
        }

        static void Main()
        {
            int[] numbers = [12, 45, 0, -56, 23, 17, 70]; 

            var minElement = FindMin(numbers);
            var maxElement = FindMax(numbers);
            var sum = SumOfNumbers(numbers);
            var count = CountEvenNumber(numbers);

            SortArray2(numbers);

            //Console.WriteLine($"Min number is {minElement}");
            //Console.WriteLine($"Max number is {maxElement}");
            //Console.WriteLine($"Sum of elements is {sum}");
            //Console.WriteLine($"Count of positive numbers is {count}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
