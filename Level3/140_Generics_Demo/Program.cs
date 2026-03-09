using System;
class Generic<T>{
public T value;
public Generic(T v){value=v;}
public void Show(){Console.WriteLine(value);}
}
class Program{
static void Main(){
Generic<int> g=new Generic<int>(10);
g.Show();
}}
