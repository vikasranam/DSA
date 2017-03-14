using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class SearchingAlgorithm
    {
        public int? LinearSearch(int[] arr, int c)
        {
            /* Loop through every value of array and compare it with value to be found */
            for (int i = 0; i < arr.Length; i++)
            {
                if (c == arr[i])
                {
                    return i;
                }
            }
            return null;
        }

        public int? BinarySearch(int[] arr, int c)
        {
            /* Declare n (array length), lb = start index, ub = last index and retValue for the value to be returned. */
            int n = arr.Length;
            int lb = 0;
            int ub = n;
            int? retValue = null;
            /* loop untill we find value */
            while (true)
            {
                /* If start index is greter than last index, than value not exist. */
                if (ub < lb)
                {
                    break;
                }
                int mid = lb + (ub - lb) / 2;
                /* Leave last 'mid' number of terms */
                if (arr[mid] > c)
                {
                    ub = mid - 1;
                }
                /* Leave first 'mid' number of terms */
                else if (arr[mid] < c)
                {
                    lb = mid + 1;
                }
                else if (arr[mid] == c)
                {
                    retValue = mid;
                    break;
                }
            }
            return retValue;
        }
    }
}
