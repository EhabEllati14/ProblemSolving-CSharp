using System;
using System.Collections.Generic;
//Done by ehab ellati
//Problem-solving number 11
namespace ConsoleApp1
{
    class Subsets_Backtracking
    {
       //here is the solution after search 
       
        public  List<List<int>> CreateSubset(int[] nums)
        {
            // we took the array and we create another list to return the subset
            List<List<int>> subsetResult = new List<List<int>>();
            List<int> subset = new List<int>();
            //we used dfs search beacuse we search deep until reach the leavs node
            //we start from the index 0
            Dfs(nums, 0, subset, subsetResult);
            return subsetResult;
        }

        // recursive by using backtracking method
        private void Dfs(int[] nums, int index, List<int> subset, List<List<int>> res)
        {
            //base condition to stop the loop
            if (index >= nums.Length)
            {
                res.Add(new List<int>(subset)); 
                return;
            }

            //we add the element on  the left of the root
            subset.Add(nums[index]);
            Dfs(nums, index + 1, subset, res);

            //we remove the element on the right of the root
            subset.RemoveAt(subset.Count - 1);
            Dfs(nums, index + 1, subset, res);
        }
    }
}

