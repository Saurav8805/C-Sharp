using System;

class GenericClass<T> where T : struct
{
    public T Value;
    public GenericClass(T v)
    {
        Value = v;
    }

    public void Display()
    {
        Console.WriteLine("Stored value: " + Value);
    }
}

class Program
{
    static void Main()
    {
        GenericClass<int> obj = new GenericClass<int>(25);
        obj.Display();
    }
}
