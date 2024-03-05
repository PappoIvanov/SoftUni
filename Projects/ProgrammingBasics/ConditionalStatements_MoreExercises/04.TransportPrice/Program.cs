
int kilometers = int.Parse(Console.ReadLine());
string periodOfDay = Console.ReadLine();

if  (kilometers < 20)
{
    switch (periodOfDay)
    {
        case "day": double taxiPriceDay = 0.70 + 0.79 * kilometers;
            Console.WriteLine($"{taxiPriceDay:f2}");
            break;
        case "night": double taxiPriceNight = 0.70 + 0.90 * kilometers;
            Console.WriteLine($"{taxiPriceNight:f2}");
            break;
    }
}
else if (kilometers >= 20 && kilometers < 100)
{
    double busPrice = 0.09 * kilometers;
    Console.WriteLine($"{busPrice:f2}");
}
else if (kilometers >= 100)
{
    double trainPrice = 0.06 * kilometers;
    Console.WriteLine($"{trainPrice:f2}");
}