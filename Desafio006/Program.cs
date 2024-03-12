// See https://aka.ms/new-console-template for more information

Console.Write("Write the first number: ");
var num1 = double.Parse(Console.ReadLine()!);

Console.Write("Write the second number: ");
var num2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("What operation do you want to perform?: ");
Console.Write("+ - * /");
string operation = Console.ReadLine()!;

switch (operation)
{
    case "+":
        Console.WriteLine($"Sum: {num1 + num2}");
        break;
    case "-":
        Console.WriteLine($"Subtraction: {num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"Multiplication: {num1 * num2}");
        break;
    case "/":
        Console.WriteLine($"Division: {num1 / num2}");
        break;
}