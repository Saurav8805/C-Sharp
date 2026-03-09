using System;
class Program
{
    static void Main()
    {
        int num = 153, sum = 0, temp = num;

        while (num > 0)
        {
            int r = num % 10;
            sum += r * r * r;
            num /= 10;
        }

        Console.WriteLine(sum == temp ? "Armstrong" : "Not Armstrong");
    }
}