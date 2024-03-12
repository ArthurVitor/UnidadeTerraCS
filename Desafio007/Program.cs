// See https://aka.ms/new-console-template for more information

List<double> nums = new List<double>();

for (int i = 0; i < 3; i++)
{
    Console.Write("Write one number: ");
    nums.Add(double.Parse(Console.ReadLine()!));
}

nums.Sort();
foreach (var num in nums)
{
    Console.Write($"{num} ");
}
