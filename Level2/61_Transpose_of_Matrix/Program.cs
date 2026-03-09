using System;
class Program{
static void Main(){
int[,] m={{1,2,3},{4,5,6}};
int r=m.GetLength(0),c=m.GetLength(1);
for(int i=0;i<c;i++){
for(int j=0;j<r;j++)
Console.Write(m[j,i]+" ");
Console.WriteLine();
}}
}
