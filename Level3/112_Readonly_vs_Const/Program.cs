using System;
class Demo{
public readonly int x=10;
public const int y=20;
}
class Program{
static void Main(){
Demo d=new Demo();
Console.WriteLine(d.x);
Console.WriteLine(Demo.y);
}}
