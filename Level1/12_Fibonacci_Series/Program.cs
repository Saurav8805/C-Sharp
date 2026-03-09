using System;
class Program
{
    static void Main()
    {
        int a = 0, b = 1, c;

        for (int i = 0; i < 10; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}