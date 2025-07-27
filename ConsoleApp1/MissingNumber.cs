using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MissingNumber
    {
        int missedNumber(int[] arr)
        {

            int expectedSum = 0;
            int actualSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                expectedSum += arr[i];

            }
            int n = arr.Length + 1;
            for (int i = 1; i <= n; i++)
            {
                actualSum += i;

            }
            return actualSum - expectedSum;
        }
    }
}
