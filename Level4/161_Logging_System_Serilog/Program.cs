using System;

class Logger{
public static void Log(string msg){
Console.WriteLine("[LOG] "+msg);
}
}

class Program{
static void Main(){
Logger.Log("Application started");
Logger.Log("Processing request");
}}
