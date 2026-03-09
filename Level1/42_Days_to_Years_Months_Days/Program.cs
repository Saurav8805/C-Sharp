using System;
class Program
{
    static void Main()
    {
        int days = 500;

        int years = days / 365;
        int months = (days % 365) / 30;
        int remainingDays = (days % 365) % 30;

        Console.WriteLine(years + " Years " + months + " Months " + remainingDays + " Days");
    }
}