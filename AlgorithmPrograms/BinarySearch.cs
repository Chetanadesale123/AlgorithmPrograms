using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public int binarySearch(String[] arr, String x)

        {
            int l = 0, r = arr.Length - 1;

            while (l <= r)
            {
                int m = l + (r - l) / 2;
                int res = x.CompareTo(arr[m]);
                // Check if x is present at mid 
                if (res == 0)
                    return m;
                // If x greater, ignore left half 
                if (res > 0)
                    l = m + 1;
                // If x is smaller, ignore right half 
                else
                    r = m - 1;
            }
            return -1;

        }
    }
}
    

