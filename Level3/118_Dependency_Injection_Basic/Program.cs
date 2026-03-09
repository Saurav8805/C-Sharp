using System;
class Service{
public void Execute(){
Console.WriteLine("Service running");
}}
class Client{
Service s;
public Client(Service s){
this.s=s;
}
public void Start(){
s.Execute();
}}
class Program{
static void Main(){
Service s=new Service();
Client c=new Client(s);
c.Start();
}}
