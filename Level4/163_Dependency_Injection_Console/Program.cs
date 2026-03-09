using System;

class Service{
public void Execute(){
Console.WriteLine("Service executed");
}
}

class Client{
Service service;
public Client(Service s){
service=s;
}

public void Run(){
service.Execute();
}
}

class Program{
static void Main(){
Service s=new Service();
Client c=new Client(s);
c.Run();
}}
