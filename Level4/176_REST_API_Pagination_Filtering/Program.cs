using System;
using System.Collections.Generic;
using System.Linq;

class Program{
static void Main(){
List<int> data=Enumerable.Range(1,50).ToList();
var page=data.Skip(10).Take(10);
foreach(var n in page)
Console.WriteLine(n);
}}
