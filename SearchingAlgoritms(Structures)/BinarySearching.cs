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
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for(int i=0;i<size;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            int x = Convert.ToInt32(Console.ReadLine());
            int result = binarySearch(arr, 0, arr.Length - 1, x);
            if (result == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element found at the index " + result);
            Console.ReadKey();
        }
    }
}

