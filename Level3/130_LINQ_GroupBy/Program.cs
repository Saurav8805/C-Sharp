using System;
using System.Linq;
class Program{
static void Main(){
int[] arr={1,1,2,2,3,3};
var g=arr.GroupBy(x=>x);
foreach(var i in g)
Console.WriteLine(i.Key+" count:"+i.Count());
}}
