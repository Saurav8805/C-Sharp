using System;
class Program{
static void Main(){
int[] arr={5,8,2,10,3};
int max=arr[0],min=arr[0];
foreach(int n in arr){
if(n>max) max=n;
if(n<min) min=n;
}
Console.WriteLine("Max="+max);
Console.WriteLine("Min="+min);
}}
