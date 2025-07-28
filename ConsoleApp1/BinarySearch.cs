using System;

namespace ConsoleApp1
{
    class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            //case --> we will check if the array is empty or not 
            if (nums.Length == 0)
            {
                Console.WriteLine("Please The array is empty !!!");
                return -1;
            }
            // we initalize the left by zero and the right the lenght of the array -1
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1; 
        }
    }
}
