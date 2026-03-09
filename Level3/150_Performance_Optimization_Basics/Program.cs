using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();

        sw.Start();

        long sum = 0;
        for(int i=0;i<1000000;i++)
        {
            sum += i;
        }

        sw.Stop();

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
