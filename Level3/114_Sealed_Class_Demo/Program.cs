using System;
sealed class Animal{
public void Speak(){
Console.WriteLine("Animal speaking");
}}
class Program{
static void Main(){
Animal a=new Animal();
a.Speak();
}}
