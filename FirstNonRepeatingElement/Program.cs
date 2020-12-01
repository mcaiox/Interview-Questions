using System;
using System.Collections.Generic;

namespace FirstNonRepeatingElement
{

    class Program
    {
        static int FNRE(int[] arr, int n)
        {
            for(int i =0; i < n; i++)
            {
                int j;
/*                Console.WriteLine("i:-> " + i + " arr[i]:-> " + arr[i]);*/
                for (j = 0; j < n; j++)
                    if (i != j && arr[i] == arr[j]) // If the element values match and they are not the same element then break out of the inner loop. (that val isn't unique)
                        break;      
                if (j == n)
                {
                    return arr[i];
                }
            }
            return -1;

        }

        static int FNREHash(int[]arr, int n)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (!d.ContainsKey(arr[i]))
                    d.Add(arr[i], 0);
                else 
                    d[arr[i]] = 1; 
            }

            for (int i = 0; i < n; i++)
            {
                if (d[arr[i]] == 0)
                    return arr[i];
            }



                return -1;
        }


        static void Main(string[] args)
        {
            int[] arr = { 9, 4, 9, 6, 7, 4 };
            int n = arr.Length;
            
            //Console.WriteLine(FNRE(arr, n));
           // Console.WriteLine(FNREHash(arr, n));
            FNREHash(arr, n);
        }
    }
}
