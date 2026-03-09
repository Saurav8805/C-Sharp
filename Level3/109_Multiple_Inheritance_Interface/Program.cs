using System;
interface IA{ void Show(); }
interface IB{ void Display(); }
class Demo:IA,IB{
public void Show(){ Console.WriteLine("Interface A"); }
public void Display(){ Console.WriteLine("Interface B"); }
}
class Program{
static void Main(){
Demo d=new Demo();
d.Show();
d.Display();
}}
