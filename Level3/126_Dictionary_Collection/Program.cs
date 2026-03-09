using System;
using System.Collections.Generic;
class Program{
static void Main(){
Dictionary<int,string> d=new Dictionary<int,string>();
d.Add(1,"A");
d.Add(2,"B");
foreach(var i in d)
Console.WriteLine(i.Key+" "+i.Value);
}}
