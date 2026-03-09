using System;
class Program
{
    static void Main()
    {
        Random r = new Random();

        for (int i = 0; i < 5; i++)
            Console.WriteLine(r.Next(1, 100));
    }
}