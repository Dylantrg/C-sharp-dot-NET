using System;
using System.Threading;
using System.Threading.Tasks;

public class Asynchronous
{
    public static async void Download()
{
    await Task.Delay(1000);
    Console.WriteLine("Hello, World!");
}
    public static void Main(String[] args)
    {
        Download();
        Console.WriteLine("Downloading...");
        Thread.Sleep(2000);
    }
}