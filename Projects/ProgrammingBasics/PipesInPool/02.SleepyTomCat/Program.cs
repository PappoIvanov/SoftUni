int offDays = int.Parse(Console.ReadLine());
int TomsNorm = 30000;
int workDays = 365 - offDays;

int playtimeWorkDays = workDays * 63;
int playtimeOffDays = offDays * 127;
int sumOfPlaytime = playtimeWorkDays + playtimeOffDays;
int sumOfRest = Math.Abs(TomsNorm - sumOfPlaytime);

if (sumOfPlaytime < TomsNorm)
{
    int hours = sumOfRest / 60;
    int minutes = sumOfRest % 60;
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
}
else
{
    int hours = sumOfRest / 60;
    int minutes = sumOfRest % 60;
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
}
