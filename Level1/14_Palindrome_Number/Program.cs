using System;
class Program
{
    static void Main()
    {
        int num = 121, rev = 0, temp = num;

        while (num != 0)
        {
            rev = rev * 10 + num % 10;
            num /= 10;
        }

        if (temp == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}