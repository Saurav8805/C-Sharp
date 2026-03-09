using System;
class Program{
static void Main(){
object obj=new object();
Console.WriteLine("Object created");
GC.Collect();
Console.WriteLine("Garbage collection executed");
}}
