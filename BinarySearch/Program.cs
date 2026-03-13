
using BinarySearch.Extensions;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = [1, 10, 13, 77, 89, 100, 200, 300, 400, 500, 600, 1000];

            var res = numbers.BinarySearch(300);

            int[] newArray = new int[10];
            newArray.SimpleSearch(5);


            int n = 10;
            n.DisplayNumber();


            int m = 20;
            m.DisplayNumber();
        }
    }
}
