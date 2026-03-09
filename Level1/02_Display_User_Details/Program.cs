using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}