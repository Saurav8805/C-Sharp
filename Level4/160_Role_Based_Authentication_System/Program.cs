using System;

class User{
public string Username;
public string Role;
}

class Program{
static void Main(){
User u=new User{Username="admin",Role="Admin"};

if(u.Role=="Admin")
Console.WriteLine("Admin Access Granted");
else
Console.WriteLine("User Access");
}}
