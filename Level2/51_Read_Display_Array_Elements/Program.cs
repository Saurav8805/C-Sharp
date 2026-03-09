using System;
class Program{
static void Main(){
int[] arr=new int[5];
for(int i=0;i<arr.Length;i++)
arr[i]=int.Parse(Console.ReadLine());
foreach(int n in arr)
Console.Write(n+" ");
}}
