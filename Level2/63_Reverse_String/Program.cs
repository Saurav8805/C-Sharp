using System;
class Program{
static void Main(){
string s="Programming";
char[] arr=s.ToCharArray();
Array.Reverse(arr);
Console.WriteLine(new string(arr));
}}
