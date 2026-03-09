using System;
using System.Linq;
class Program{
static void Main(){
int[] arr={1,2,2,3,4,4,5};
var result=arr.Distinct();
foreach(int n in result)
Console.Write(n+" ");
}}
