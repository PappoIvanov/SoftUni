double num = double.Parse(Console.ReadLine());
double bonus = 0;

if  (num <= 100)
{
    bonus = 5;
}
else if (num > 1000)
{
    bonus = num * 0.1;
}
else if (num > 100)
{
    bonus = num * 0.2;
}

int additionalBonus = 0;
if  (num % 2 == 0)
{
    additionalBonus += 1;
}
if (num % 10 == 5)
{
    additionalBonus += 2;
}

Console.WriteLine($"{bonus + additionalBonus}");
Console.WriteLine($"{num + bonus + additionalBonus}");