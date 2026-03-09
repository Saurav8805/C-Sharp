using System;
class Program{
static void Main(){
int[,] a={{1,2},{3,4}};
int[,] b={{5,6},{7,8}};
int[,] c=new int[2,2];
for(int i=0;i<2;i++)
for(int j=0;j<2;j++)
for(int k=0;k<2;k++)
c[i,j]+=a[i,k]*b[k,j];
Console.WriteLine(c[0,0]+" "+c[0,1]);
Console.WriteLine(c[1,0]+" "+c[1,1]);
}}
