using System;
using System.Linq;
class Program{
static void Main(){
int[] arr={1,2,3,4,5};
var res=arr.Where(x=>x>2).Select(x=>x*10);
foreach(var i in res)
Console.WriteLine(i);
}}
