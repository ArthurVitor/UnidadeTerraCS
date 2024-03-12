// See https://aka.ms/new-console-template for more information

Console.Write("What's your monthly wage? ");
var fixedWage = double.Parse(Console.ReadLine()!);
        
Console.Write("Total sale");
var totalSales = double.Parse(Console.ReadLine()!);
        
Console.Write("Commission Rate");
var commissionRate = double.Parse(Console.ReadLine()!) / 100;

Console.WriteLine($"Wage to receive: {fixedWage + (totalSales * commissionRate)}");