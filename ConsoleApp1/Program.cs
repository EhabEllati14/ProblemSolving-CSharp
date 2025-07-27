using ConsoleApp1;

MergeTwoSortedArrays merge = new MergeTwoSortedArrays();
int [] arr1 = { 1, 5, 7, 10 };
int[]  arr2 = { 2, 3, 4, 8 ,90,100,110,600};
int [] result=merge.mergeTwoSortedArray(arr1, arr2);

foreach(int i in result)
{
    Console.WriteLine(i);
}