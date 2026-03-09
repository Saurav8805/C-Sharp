using System;

class Employee{
public string Name;
public double Salary;

public double CalculateAnnual(){
return Salary*12;
}
}

class Program{
static void Main(){
Employee e=new Employee{Name="Saurav",Salary=25000};
Console.WriteLine(e.Name+" Annual Salary:"+e.CalculateAnnual());
}}
