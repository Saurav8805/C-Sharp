using System;
using System.Linq;
class Program{
static void Main(){
string a="listen";
string b="silent";
bool result=String.Concat(a.OrderBy(c=>c))==String.Concat(b.OrderBy(c=>c));
Console.WriteLine(result?"Anagram":"Not");
}}
