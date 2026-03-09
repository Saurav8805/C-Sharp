using System;
class Car{
string model;
public Car(string m){
model=m;
}
public void Show(){
Console.WriteLine("Model: "+model);
}}
class Program{
static void Main(){
Car c=new Car("Tesla");
c.Show();
}}
