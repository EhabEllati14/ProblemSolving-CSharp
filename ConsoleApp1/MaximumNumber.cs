using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MaximumNumber
    {
        public int maxNumber(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Please The Array is Empty !");
            }
            int max1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max1 = arr[i];
                }
            }
            return max1;

        }
    }
}
