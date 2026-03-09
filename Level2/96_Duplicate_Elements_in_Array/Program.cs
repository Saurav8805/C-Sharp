using System;
using System.Linq;
class Program{
static void Main(){
int[] arr={1,2,2,3,3,4};
var dup=arr.GroupBy(x=>x)
.Where(g=>g.Count()>1)
.Select(g=>g.Key);
foreach(int d in dup)
Console.WriteLine(d);
}}
