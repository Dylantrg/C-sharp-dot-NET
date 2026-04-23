using System;
using System.Threading;
using System.Threading.Tasks;

public class Asynchronous
{
    public async Task Download1()
{
    await Task.Delay(1000);
    Console.WriteLine("Download 1 completed");
}

public async Task Download2()
    {
        await Task.Delay(2000);
        Console.WriteLine("Download 2 completed");  
    }
    public static async Task Main(String[] args)
    {
        Asynchronous test = new Asynchronous();
        Console.WriteLine("Downloading...");
        Task task1 = test.Download1();
        Task task2 = test.Download2();
        await Task.WhenAll(task1, task2);    
        Console.WriteLine("Downloaded");
    }
}