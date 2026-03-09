using System;
class Program{
static void Greet(string name="Guest"){
Console.WriteLine("Hello "+name);
}
static void Main(){
Greet();
Greet("John");
}}
