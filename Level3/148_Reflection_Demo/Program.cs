using System;
using System.Reflection;

class Demo
{
    public void Show()
    {
        Console.WriteLine("Reflection method executed");
    }
}

class Program
{
    static void Main()
    {
        Type t = typeof(Demo);

        Console.WriteLine("Methods in Demo class:");

        foreach(var m in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }

        Demo d = new Demo();
        t.GetMethod("Show").Invoke(d,null);
    }
}
