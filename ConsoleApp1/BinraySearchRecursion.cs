using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BinraySearchRecursion
    {
        public int Search(int[] nums, int left, int right, int target)
        {
            if(nums.Length == 0)
            {
                Console.WriteLine("Please The array is empty !!!");
                return -1;
            }
            if (left > right)
                return -1;
            int mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
               return Search(nums, left, mid - 1, target);
            }
            else
            {
               return Search(nums, mid + 1, right, target);
            }
        }
    }
}
