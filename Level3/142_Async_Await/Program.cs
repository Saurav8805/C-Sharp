using System;
using System.Threading.Tasks;

class Program
{
    static async Task DoWork()
    {
        Console.WriteLine("Task started...");
        await Task.Delay(2000);
        Console.WriteLine("Task finished after delay");
    }

    static async Task Main()
    {
        Console.WriteLine("Main started");
        await DoWork();
        Console.WriteLine("Main finished");
    }
}
