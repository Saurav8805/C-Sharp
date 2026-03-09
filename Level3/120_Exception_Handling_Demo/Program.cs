using System;
class Program{
static void Main(){
try{
int a=10,b=0;
Console.WriteLine(a/b);
}
catch(Exception e){
Console.WriteLine("Error: "+e.Message);
}
}}
