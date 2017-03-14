using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new SearchingAlgorithm();
            int[] arr = new int[10]{ 1, 4, 6, 7, 8, 12, 23, 34, 38, 40 };
            int Value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(logic.BinarySearch(arr, Value));
        }
    }
}
