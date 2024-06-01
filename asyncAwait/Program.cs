// See https://aka.ms/new-console-template for more information
using asyncAwait;

Console.WriteLine("Hello, World!");

int result = await Helper.performTask();
Console.WriteLine("result : "+$"{result}");
Console.WriteLine("program ends");