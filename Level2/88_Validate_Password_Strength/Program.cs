using System;
using System.Text.RegularExpressions;
class Program{
static void Main(){
string pass="Test@1234";
bool strong=Regex.IsMatch(pass,@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$");
Console.WriteLine(strong?"Strong":"Weak");
}}
