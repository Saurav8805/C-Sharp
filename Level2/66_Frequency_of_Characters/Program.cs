using System;
using System.Collections.Generic;
class Program{
static void Main(){
string s="hello world";
Dictionary<char,int> map=new();
foreach(char c in s){
if(c==' ') continue;
if(map.ContainsKey(c)) map[c]++;
else map[c]=1;
}
foreach(var p in map)
Console.WriteLine(p.Key+"="+p.Value);
}}
