using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program{
static async Task Main(){
HttpClient client=new HttpClient();
string result=await client.GetStringAsync("https://api.github.com");
Console.WriteLine("API Response Length:"+result.Length);
}}
