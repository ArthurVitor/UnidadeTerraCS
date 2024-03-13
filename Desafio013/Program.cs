// See https://aka.ms/new-console-template for more information

int [] numbers = [1,2,3,4,5,6];
int contOdd = 0;
int contEven = 0;
int contNegative = 0;

foreach (var number in numbers)
{
    if (number < 0)
    {
        contNegative++;
    }

    if (number % 2 == 0)
    {
        contEven++;
    }
    else
    {
        contOdd++;
    }
}

Console.WriteLine($"Odd: {contOdd} Even: {contEven} Negative: {contNegative}");