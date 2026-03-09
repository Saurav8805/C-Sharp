using System;
using System.Collections.Generic;

class Book{
public string Title;
public string Author;
}

class Program{
static void Main(){
List<Book> books=new List<Book>{
new Book{Title="C# Basics",Author="John"},
new Book{Title="ASP.NET Guide",Author="Smith"}
};

foreach(var b in books)
Console.WriteLine(b.Title+" by "+b.Author);
}}
