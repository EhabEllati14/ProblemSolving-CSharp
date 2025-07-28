using ConsoleApp1;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        //Console.WriteLine("Starting all tasks in parallel...");

        //// Run 3 tasks at the same time
        //Task t1 = Task.Run(async () =>
        //{
        //    Console.WriteLine("Task1 started");
        //    await Task.Delay(3000); // simulate 3 sec work
        //    Console.WriteLine("Task1 finished");
        //});

        //Task t2 = Task.Run(async () =>
        //{
        //    Console.WriteLine("Task2 started");
        //    await Task.Delay(1000); // simulate 1 sec work
        //    Console.WriteLine("Task2 finished");
        //});

        //Task t3 = Task.Run(async () =>
        //{
        //    Console.WriteLine("Task3 started");
        //    await Task.Delay(2000); // simulate 2 sec work
        //    Console.WriteLine("Task3 finished");
        //});

        //// Wait for ALL tasks to finish
        //await Task.WhenAll(t1, t2, t3);

        //Console.WriteLine("All tasks finished in parallel!");


        //Subsets_Backtracking subset = new Subsets_Backtracking();
        //int[] arr = { 1, 2, 3};
        //List<List<int>> result = subset.CreateSubset(arr);


        //foreach (var sub in result)
        //{
        //    Console.WriteLine("[" + string.Join(", ", sub) + "]");
        //}

        BinarySearch search = new BinarySearch();
        int[] arr = { 5, 10, 15, 20, 25, 30, 35 };
        int index = search.Search(arr, 15);
        Console.WriteLine("The result is : " + index);

        BinraySearchRecursion binarysearch = new BinraySearchRecursion();
        int index2=binarysearch.Search(arr,0,6,15);
        Console.WriteLine("The Result by using recusrion : "+ index2); 


    }
}
