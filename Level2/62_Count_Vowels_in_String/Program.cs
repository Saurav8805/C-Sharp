using System;
using System.Linq;
class Program{
static void Main(){
string s="Hello World";
int count=s.Count(c=>"aeiouAEIOU".Contains(c));
Console.WriteLine("Vowels="+count);
}}
