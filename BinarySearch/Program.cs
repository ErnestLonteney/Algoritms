namespace BinarySearch
{
    internal class Program
    {
        static int SimpleSearch(int[] arr, int target) // O(n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }

            return -1;
        }

        static int BinarySearch(int[] arr, int target)    // O(log n)
        {
            int leftIndex = 0;
            int rightIndex = arr.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;

                if (arr[middleIndex] == target)
                   return middleIndex;
                else 
                    if (target > arr[middleIndex] )
                    leftIndex = middleIndex + 1;
                else
                    rightIndex = middleIndex - 1;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] numbers = [1, 10, 13, 77, 89, 100, 200, 300, 400, 500, 600, 1000]; 

            var res = BinarySearch(numbers, 300);

            Console.WriteLine(res);
        }
    }
}
