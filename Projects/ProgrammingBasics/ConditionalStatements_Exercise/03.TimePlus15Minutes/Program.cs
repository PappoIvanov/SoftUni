int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int hoursInMinutes = hours * 60;
int sumOfTime = minutes + hoursInMinutes + 15;

int newHours = sumOfTime / 60;
int newMinutes = sumOfTime % 60;

if (newHours >= 24)
{
    if (newMinutes < 10)
    {
        Console.WriteLine($"0:0{newMinutes}");
    }
    else
    {
        Console.WriteLine($"0:{newMinutes}");
    }
}
else
{
    if (newMinutes < 10)
    {
        Console.WriteLine($"{newHours}:0{newMinutes}");
    }
    else
    {
        Console.WriteLine($"{newHours}:{newMinutes}");
    }
}