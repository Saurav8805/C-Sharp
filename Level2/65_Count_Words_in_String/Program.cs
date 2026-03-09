using System;
class Program{
static void Main(){
string s="C sharp programming language";
int words=s.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length;
Console.WriteLine("Words="+words);
}}
