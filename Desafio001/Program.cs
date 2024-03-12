// See https://aka.ms/new-console-template for more information

Console.Write("Write the first value: ");
string? valueOne = Console.ReadLine();

Console.Write("Write the second value: ");
string? valueTwo = Console.ReadLine();
        
Console.Write("Write the third value: ");
string? valueThree = Console.ReadLine();

Console.WriteLine("Numbers");
Console.WriteLine($"{valueOne} {valueTwo} {valueThree}");
        
string valueTemp = valueTwo;

valueTwo = valueThree;
valueThree = valueOne;
valueOne = valueTemp;
        
Console.WriteLine("Numbers swapped");
Console.WriteLine($"{valueOne} {valueTwo} {valueThree}");