int num = int.Parse(Console.ReadLine());
double bonus = 0.0;

if (num <= 100)
{
    bonus = 5;
    double fullNum = num + bonus;
}
else if (num <= 1000)
{
    bonus = num * 0.2;
    double fullNum = num + bonus;
}
else
{
    bonus = (num * 0.1);
    double fullNum = num + bonus;
}
if (num % 2 == 0)
{
    bonus = bonus + 1;
    Console.WriteLine(bonus);
}
else if (num % 10 == 5)
{
    bonus = bonus + 2;
    Console.WriteLine(bonus);
}
else { Console.WriteLine(bonus); }

Console.WriteLine($"{num + bonus}");