using System;

[AttributeUsage(AttributeTargets.Class)]
class InfoAttribute : Attribute
{
    public string Message;
    public InfoAttribute(string msg)
    {
        Message = msg;
    }
}

[Info("Custom attribute example")]
class Demo
{
}

class Program
{
    static void Main()
    {
        var attrs = typeof(Demo).GetCustomAttributes(false);

        foreach(var a in attrs)
        {
            InfoAttribute info = (InfoAttribute)a;
            Console.WriteLine(info.Message);
        }
    }
}
