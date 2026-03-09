using System;
class Student{
public string Name;
public int Age;
public void Display(){
Console.WriteLine("Name: "+Name);
Console.WriteLine("Age: "+Age);
}}
class Program{
static void Main(){
Student s=new Student();
s.Name="Saurav";
s.Age=20;
s.Display();
}}
