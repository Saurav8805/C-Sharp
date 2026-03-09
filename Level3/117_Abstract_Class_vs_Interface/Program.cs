using System;
abstract class A{
public abstract void Test();
}
interface I{
void Run();
}
class Demo:A,I{
public override void Test(){
Console.WriteLine("Abstract method");
}
public void Run(){
Console.WriteLine("Interface method");
}}
class Program{
static void Main(){
Demo d=new Demo();
d.Test();
d.Run();
}}
