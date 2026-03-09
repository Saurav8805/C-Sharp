using System;
using System.Collections.Generic;
class Program{
static void Main(){
HashSet<int> h=new HashSet<int>();
h.Add(1);
h.Add(2);
h.Add(2);
foreach(int n in h)
Console.WriteLine(n);
}}
