// See https://aka.ms/new-console-template for more information

Console.Write("Write the first number: ");
var valueOne = double.Parse(Console.ReadLine()!);
        
Console.Write("Write the second number: ");
var valueTwo = double.Parse(Console.ReadLine()!);
        
Console.WriteLine($"Sum: {valueOne + valueTwo}");
Console.WriteLine($"Subtraction: {valueOne - valueTwo}");
Console.WriteLine($"Multiplication: {valueOne * valueTwo}");
Console.WriteLine($"Division: {valueOne / valueTwo}");