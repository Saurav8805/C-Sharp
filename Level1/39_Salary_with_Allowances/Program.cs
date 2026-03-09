using System;
class Program
{
    static void Main()
    {
        double basic = 10000;
        double hra = basic * 0.2;
        double da = basic * 0.1;

        Console.WriteLine("Total Salary = " + (basic + hra + da));
    }
}