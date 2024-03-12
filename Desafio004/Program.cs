// See https://aka.ms/new-console-template for more information

Console.Write("Write a number: ");
var num = double.Parse(Console.ReadLine()!);
if (num >= 0)
{
    Console.WriteLine("Positivo");
}
else
{
    Console.WriteLine("Negativo");
}