using System;
static class Extension{
public static int Square(this int x){
return x*x;
}}
class Program{
static void Main(){
int n=5;
Console.WriteLine(n.Square());
}}
