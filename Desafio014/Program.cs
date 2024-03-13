// See https://aka.ms/new-console-template for more information

List<int> numbers = new List<int>(){4,121,512,432,426,123,6784,5,3};
int option = 0;

while (option < 1 || option > 7)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1: List numbers \n" +
                      "2: Add a number to the end \n" +
                      "3: Remove a number based on its index \n" +
                      "4: Remove a number based on the value (Remove all occurrences) \n" +
                      "5: Order the numbers in a ascending order \n" +
                      "6: Order the numbers in a descending order \n" +
                      "7: Sum all values");
    Console.Write("Option: ");
    option = int.Parse(Console.ReadLine()!);
    Console.WriteLine(" ");
}

switch (option)
{
    case 1:
        foreach (var number in numbers)
        {
            Console.WriteLine("Numbers: ");
            Console.Write(number);
        }
        break;
    case 2:
        Console.WriteLine("Write the number: ");
        numbers.Add(int.Parse(Console.ReadLine()!));
        break;
    case 3:
        Console.WriteLine("Write the index: ");
        numbers.RemoveAt(int.Parse(Console.ReadLine()!));
        break;
    case 4:
        Console.WriteLine("Write a number: ");
        numbers.RemoveAll(x => x == int.Parse(Console.ReadLine()!));
        break;
    case 5:
        numbers.Order();
        break;
}