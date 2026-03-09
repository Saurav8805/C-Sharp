using System;
class Program{
static void Main(){
int[] arr={10,20,30,40,50};
int sum=0;
foreach(int n in arr) sum+=n;
Console.WriteLine("Sum="+sum);
Console.WriteLine("Avg="+(sum/(double)arr.Length));
}}
