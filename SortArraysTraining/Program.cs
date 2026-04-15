using SortArraysTraining;

class Program
{
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

    static void SelectionSort(int[] arr)
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

    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    var buf = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = buf;
                }
            }
        }
    }

    static int BinarySearch(int[] arr, int target)
    {
        int leftIndex = 0;
        int rightIndex = arr.Length - 1;

        while (leftIndex <= rightIndex)
        {
            int middleIndex = (leftIndex + rightIndex) / 2;

            if (arr[middleIndex] == target)
                return middleIndex;
            
                if (target > arr[middleIndex])
                    leftIndex = middleIndex + 1;
                else
                    rightIndex = middleIndex - 1;
        }

        return -1;
    }

    static void Main(string[] args)
    {
        SortDelegate del = new SortDelegate(SelectionSort);

        int[] numbers = [12, 45, 0, -56, 23, 17, 70];

        numbers.SortIntArrayAndDisplay(del);
        numbers.SortIntArrayAndDisplay(BubbleSort);
    }
}