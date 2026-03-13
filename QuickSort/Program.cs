namespace QuickSort
{
    internal class Program
    {
        static int[] QuickSort(int[] array)
        {
            if (array.Length < 2)
                return array;

            var pivot = array[0];
            var rest = array[1..];

            var ar1 = rest.Where(x => x < pivot).ToArray();
            var ar2 = rest.Where(x => x > pivot).ToArray();

            return [..QuickSort(ar1), pivot, ..QuickSort(ar2)];
        }

        static void Main()
        {
            int[] array = [ 5, 2, 9, 1, 5, 6 ];

            var res = QuickSort(array);

            Console.WriteLine(string.Join(", ", res));
        }
    }
}
