using System;
using System.Collections.Generic;
class Program{
static void Main(){
Stack<int> s=new Stack<int>();
s.Push(10);
s.Push(20);
Console.WriteLine(s.Pop());
Queue<int> q=new Queue<int>();
q.Enqueue(5);
q.Enqueue(15);
Console.WriteLine(q.Dequeue());
}}
