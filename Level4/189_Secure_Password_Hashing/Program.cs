using System;
using System.Security.Cryptography;
using System.Text;

class Program{
static void Main(){
string password="mypassword";
var sha=SHA256.Create();
var hash=sha.ComputeHash(Encoding.UTF8.GetBytes(password));
Console.WriteLine(Convert.ToBase64String(hash));
}}
