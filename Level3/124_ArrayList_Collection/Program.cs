using System;
using System.Collections;
class Program{
static void Main(){
ArrayList list=new ArrayList();
list.Add(10);
list.Add(20);
list.Add("Hello");
foreach(var i in list)
Console.WriteLine(i);
}}
