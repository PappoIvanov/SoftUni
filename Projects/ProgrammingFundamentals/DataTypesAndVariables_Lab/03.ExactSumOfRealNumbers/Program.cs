int countOfNumbers = int.Parse(Console.ReadLine());
decimal sum = 0;

for (int i = 0; i < countOfNumbers; i++)
{
    decimal number = decimal.Parse(Console.ReadLine());
    sum += number;
}
Console.WriteLine(sum);