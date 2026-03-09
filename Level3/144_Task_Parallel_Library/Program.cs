using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Parallel.For(1,6,i =>
        {
            Console.WriteLine("Processing number: " + i);
        });

        Console.WriteLine("Parallel loop completed");
    }
}
