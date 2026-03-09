using System;

class BankAccount{
public double Balance;

public void Deposit(double amt){
Balance+=amt;
}

public void Withdraw(double amt){
if(amt<=Balance) Balance-=amt;
}

}

class Program{
static void Main(){
BankAccount a=new BankAccount();
a.Deposit(1000);
a.Withdraw(300);
Console.WriteLine("Balance:"+a.Balance);
}}
