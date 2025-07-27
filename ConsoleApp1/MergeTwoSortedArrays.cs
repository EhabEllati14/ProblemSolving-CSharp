class MergeTwoSortedArrays
{
    public int[] MergeTwoSortedArray(int[] arr1, int[] arr2)
    {
        // Handle edge cases first
        if (arr1.Length == 0 && arr2.Length == 0)
        {
            Console.WriteLine("Both arrays are empty!");
            return new int[0];
        }
        if (arr1.Length == 0) return arr2;
        if (arr2.Length == 0) return arr1;

        List<int> list = new List<int>();
        int i = 0, j = 0;

        // Merge step
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                list.Add(arr1[i]);
                i++;
            }
            else if (arr1[i] > arr2[j])
            {
                list.Add(arr2[j]);
                j++;
            }
            else
            {
                // both are equal
                list.Add(arr1[i]);
                i++;
                j++;
            }
        }

  
        while (i < arr1.Length)
        {
            list.Add(arr1[i]);
            i++;
        }

        while (j < arr2.Length)
        {
            list.Add(arr2[j]);
            j++;
        }

        return list.ToArray();
    }
}
