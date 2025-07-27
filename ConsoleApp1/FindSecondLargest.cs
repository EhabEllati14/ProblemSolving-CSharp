using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FindSecondLargest
    {

        static int secondLargest(int[] arr)
        {
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {

                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2)
                {
                    max2 = arr[i];


                }
            }
            return max2;
        }
    }
}
