using System;
class Program{
static void Square(int x,out int result){
result=x*x;
}
static void Main(){
int r;
Square(6,out r);
Console.WriteLine(r);
}}
