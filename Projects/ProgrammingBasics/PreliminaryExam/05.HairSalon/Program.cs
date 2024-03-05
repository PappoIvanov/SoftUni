int targetOfTheDay = int.Parse(Console.ReadLine());
string text = Console.ReadLine();

int price = 0, totalSum = 0;
bool targerCompleted = false;

while (text != "closed")
{

    if (text == "haircut")
    {
        string typeOfHaircut = Console.ReadLine();
        switch (typeOfHaircut)
        {
            case "mens": price += 15; totalSum += 15; break;
            case "ladies": price += 20; totalSum += 20; break;
            case "kids": price += 10; totalSum += 10; break;
        }
    }
    else if (text == "color")
    {
        string colorType = Console.ReadLine();
        switch (colorType)
        {
            case "touch up": price += 20; totalSum += 20; break;
            case "full color": price += 30; totalSum += 30; break;
        }
    }

    if (targetOfTheDay <= totalSum) { targerCompleted = true; break; }

    price = 0;
    text = Console.ReadLine();
}

if (targerCompleted)
{
    Console.WriteLine("You have reached your target for the day!");
    Console.WriteLine($"Earned money: {totalSum}lv.");
}
else if (!targerCompleted)
{
    int neededMoney = targetOfTheDay - totalSum;
    Console.WriteLine($"Target not reached! You need {neededMoney}lv. more.");
    Console.WriteLine($"Earned money: {totalSum}lv.");
}