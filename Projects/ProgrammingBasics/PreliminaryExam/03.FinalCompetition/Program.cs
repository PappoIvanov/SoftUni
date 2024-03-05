int dancersCount = int.Parse(Console.ReadLine());
double points = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string country = Console.ReadLine();

double prize = 0, prizeForCharity = 0, moneyLeft = 0, moneyForDancer = 0;

if (country == "Bulgaria")
{
    prize = dancersCount * points;
    switch (season)
    {
        case "summer": prize *= 0.95; break;
        case "winter": prize *= 0.92; break;
    }
}
else if (country == "Abroad")
{
    prize = dancersCount * points * 1.50;
    switch (season)
    {
        case "summer": prize *= 0.90; break;
        case "winter": prize *= 0.85; break;
    }
}

prizeForCharity = prize * 0.75;
moneyLeft = prize - prizeForCharity;
moneyForDancer = moneyLeft / dancersCount;

Console.WriteLine($"Charity - {prizeForCharity:f2}");
Console.WriteLine($"Money per dancer - {moneyForDancer:f2}");
