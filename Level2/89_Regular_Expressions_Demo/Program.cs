using System;
using System.Text.RegularExpressions;
class Program{
static void Main(){
string s="abc123xyz";
var m=Regex.Match(s,@"\d+");
Console.WriteLine(m.Value);
}}
