using System;
using System.Linq;
class Program{
static void Main(){
int[] arr={4,9,1,7,9,5};
var second=arr.Distinct().OrderByDescending(x=>x).Skip(1).First();
Console.WriteLine(second);
}}
