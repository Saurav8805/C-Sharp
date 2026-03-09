using System;
delegate void MyDel();
class Program{
static void A(){Console.WriteLine("Method A");}
static void B(){Console.WriteLine("Method B");}
static void Main(){
MyDel d=A;
d+=B;
d();
}}
