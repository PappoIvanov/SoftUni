//  Diesel, Gasoline или Gas

string fuelType = Console.ReadLine();
double volumeOfFule = double.Parse(Console.ReadLine());

if (fuelType == "Diesel")
{
    if (volumeOfFule >= 25)
    {
        Console.WriteLine($"You have enough diesel.");
    }
    else if (volumeOfFule < 25)
    {
        Console.WriteLine($"Fill your tank with diesel!");
    }
}
else if (fuelType == "Gasoline")
{
    if (volumeOfFule >= 25)
    {
        Console.WriteLine($"You have enough gasoline.");
    }
    else if (volumeOfFule < 25)
    {
        Console.WriteLine($"Fill your tank with gasoline!");
    }
}
else if (fuelType == "Gas")
{
    if (volumeOfFule >= 25)
    {
        Console.WriteLine($"You have enough gas.");
    }
    else if (volumeOfFule < 25)
    {
        Console.WriteLine($"Fill your tank with gas!");
    }
}
else
{
    Console.WriteLine("Invalid fuel!");
}

