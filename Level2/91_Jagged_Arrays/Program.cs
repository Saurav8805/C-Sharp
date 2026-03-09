using System;
class Program{
static void Main(){
int[][] arr={
new int[]{1,2},
new int[]{3,4,5}
};
foreach(var row in arr){
foreach(int n in row)
Console.Write(n+" ");
Console.WriteLine();
}}
}
