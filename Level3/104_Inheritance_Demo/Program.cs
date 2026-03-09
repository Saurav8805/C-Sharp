using System;
class Animal{
public void Eat(){
Console.WriteLine("Animal eating");
}}
class Dog:Animal{
public void Bark(){
Console.WriteLine("Dog barking");
}}
class Program{
static void Main(){
Dog d=new Dog();
d.Eat();
d.Bark();
}}
