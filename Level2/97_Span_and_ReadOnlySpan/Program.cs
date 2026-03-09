using System;
class Program{
static void Main(){
int[] arr={1,2,3,4,5};
Span<int> span=arr.AsSpan(1,3);
foreach(int n in span)
Console.Write(n+" ");
}}
