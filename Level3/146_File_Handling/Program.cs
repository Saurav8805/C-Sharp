using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path="demo.txt";

        File.WriteAllText(path,"Hello File Handling\n");

        File.AppendAllText(path,"Appending new line\n");

        string data = File.ReadAllText(path);

        Console.WriteLine("File Content:");
        Console.WriteLine(data);
    }
}
