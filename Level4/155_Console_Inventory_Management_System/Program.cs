using System;
using System.Collections.Generic;

class Item{
public string Name;
public int Qty;
}

class Program{
static void Main(){
List<Item> items=new List<Item>{
new Item{Name="Laptop",Qty=5},
new Item{Name="Mouse",Qty=20}
};

foreach(var i in items)
Console.WriteLine(i.Name+" Stock:"+i.Qty);
}}
