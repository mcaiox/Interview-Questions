using System;
using System.Collections;

namespace FindMinimumInRotatedSortedArray
{
    class FMIRSA
    {
        public static int findMin(int[] num)
        {
            if (num == null || num.Length == 0)
            {
                return Int32.MinValue;
            }

            int start = 0;
            int end = num.Length - 1;
            /*            Console.WriteLine("num[start] is " + num[start]);*/
            while (start + 1 < end)
            {

                int mid = start + (end - start) / 2;
                /*                Console.WriteLine("num[start] is " + num[start]);
                                Console.WriteLine("num[mid] is " + num[mid]);
                                Console.WriteLine("num[end] is " + num[end]);*/
                if (num[start] < num[end])
                {
                    end = mid;
                }
                else if (num[start] < num[mid])
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }
            }
            /*            Console.WriteLine("num[start] is " + num[start]);
                        Console.WriteLine("num[end] is " + num[end]);*/
            if (num[start] < num[end])
            {
                return num[start];
            }
            else
            {
                return num[end];
            }

        }
    }
    class Program : FMIRSA
    {

        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 1, 2 };
            Console.WriteLine(findMin(arr));
        }


        
    }
}
