using System;
class Program
{
    static void Main()
    {
        int a = 10, b = 25, c = 15;
        int largest = Math.Max(a, Math.Max(b, c));
        Console.WriteLine("Largest = " + largest);
    }
}