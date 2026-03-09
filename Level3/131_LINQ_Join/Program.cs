using System;
using System.Linq;
class Program{
static void Main(){
var a=new[]{1,2,3};
var b=new[]{1,2,4};
var j=a.Join(b,x=>x,y=>y,(x,y)=>x);
foreach(var i in j)
Console.WriteLine(i);
}}
