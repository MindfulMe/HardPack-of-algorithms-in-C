using System;

namespace Binary
{
    class Program
    {
        static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);
                else
                    return binarySearch(arr, mid + 1, r, x);
            }
            return -1;
        }




        public static void Main(string[] args)
        {
            int[] arr = { 3, 4, 23, 42, 77, 100 };
            int x = 42;
            int result = binarySearch(arr, 0, arr.Length - 1, x);
            if (result == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element found at the index " + result);
            Console.ReadKey();
        }
    }
}

