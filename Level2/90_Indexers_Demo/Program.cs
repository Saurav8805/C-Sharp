using System;
class Sample{
int[] arr=new int[5];
public int this[int i]{
get=>arr[i];
set=>arr[i]=value;
}}
class Program{
static void Main(){
Sample s=new();
s[0]=10;
Console.WriteLine(s[0]);
}}
