using System;
class Program{
static void Main(){
Func<int,int> square=x=>x*x;
Action<string> print=s=>Console.WriteLine(s);
Predicate<int> check=x=>x>5;
print(square(4).ToString());
Console.WriteLine(check(10));
}}
