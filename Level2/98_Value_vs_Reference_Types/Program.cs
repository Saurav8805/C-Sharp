using System;
class Program{
static void Main(){
int a=10;
int b=a;
b=20;
Console.WriteLine("Value type:"+a);

int[] x={1,2};
int[] y=x;
y[0]=99;
Console.WriteLine("Reference type:"+x[0]);
}}
