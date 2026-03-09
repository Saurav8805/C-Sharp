using System;
using System.IO;

class Program{
static void Main(){
string path="data.txt";

File.WriteAllText(path,"Hello CRUD");

string data=File.ReadAllText(path);

Console.WriteLine(data);

File.AppendAllText(path,"\nUpdated");

Console.WriteLine(File.ReadAllText(path));
}}
