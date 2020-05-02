using System;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace BinarySearch
{
    class Program
    {
        private const int ArrLength = 5000;
        private const int ItemToFind = 2500;


        static void Main(string[] args)
        {
            Init();
        }

        private static void Init()
        {
            var array = CreateArray();

            foreach (var item in array)
                Console.Write(item + " ");

            Console.WriteLine();

            int indexInArray = ElementIndexBinarySearch(array, ItemToFind);

            Console.WriteLine("\n" + $"Index of {ItemToFind} in array is: " + indexInArray + "\n");
        }

        private static int ElementIndexBinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length;

            while (!(left >= right))
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == key)
                    return mid;

                if (arr[mid] > key)
                    right = mid;
                else
                    left = mid + 1;
            }

            return -1;
        }

        private static int[] CreateArray()
        {
            var array = new int[ArrLength];

            for (int i = 0; i < array.Length; i++)
                array[i] = i;

            return array;
        }
    }
}
