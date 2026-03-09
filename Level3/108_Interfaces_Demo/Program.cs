using System;
interface IAnimal{
void Speak();
}
class Dog:IAnimal{
public void Speak(){
Console.WriteLine("Dog barks");
}}
class Program{
static void Main(){
IAnimal a=new Dog();
a.Speak();
}}
