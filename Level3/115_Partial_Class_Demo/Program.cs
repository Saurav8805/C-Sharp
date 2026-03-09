using System;
partial class Demo{
public void Show(){
Console.WriteLine("Partial part 1");
}}
partial class Demo{
public void Display(){
Console.WriteLine("Partial part 2");
}}
class Program{
static void Main(){
Demo d=new Demo();
d.Show();
d.Display();
}}
