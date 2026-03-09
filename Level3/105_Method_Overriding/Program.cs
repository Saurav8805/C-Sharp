using System;
class Parent{
public virtual void Show(){
Console.WriteLine("Parent method");
}}
class Child:Parent{
public override void Show(){
Console.WriteLine("Child override");
}}
class Program{
static void Main(){
Parent p=new Child();
p.Show();
}}
