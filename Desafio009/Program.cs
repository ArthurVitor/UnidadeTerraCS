// See https://aka.ms/new-console-template for more information

Console.Write("Write a number do display it Times Table; ");
var num = double.Parse(Console.ReadLine()!);
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} * {i} = {num * i}");
}