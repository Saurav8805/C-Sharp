using System;
using System.Linq;
class Program{
static void Main(){
string s="madam";
string rev=new string(s.Reverse().ToArray());
Console.WriteLine(s.Equals(rev,StringComparison.OrdinalIgnoreCase)?"Palindrome":"Not");
}}
