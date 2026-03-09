using System;
using System.Text.RegularExpressions;
class Program{
static void Main(){
string s="Hello@123#World!";
Console.WriteLine(Regex.Replace(s,"[^a-zA-Z0-9 ]",""));
}}
