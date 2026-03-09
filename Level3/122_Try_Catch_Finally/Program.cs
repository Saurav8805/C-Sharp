using System;
class Program{
static void Main(){
try{
int x=int.Parse("abc");
}
catch(Exception e){
Console.WriteLine("Exception: "+e.Message);
}
finally{
Console.WriteLine("Finally block executed");
}
}}
