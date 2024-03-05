int runningDays = int.Parse(Console.ReadLine());
double firstDayKilometers = double.Parse(Console.ReadLine());
double nextDayKilometers = firstDayKilometers;
double sumOfKilomersPerDay = firstDayKilometers;

for (int i = 1; i <= runningDays; i++)
{
    double percentagesAdded = double.Parse(Console.ReadLine());
    nextDayKilometers += (nextDayKilometers * percentagesAdded / 100);
    sumOfKilomersPerDay += nextDayKilometers;
}

if (sumOfKilomersPerDay >= 1000)
{
    double moreThanGoal = Math.Ceiling(sumOfKilomersPerDay - 1000);
    Console.WriteLine($"You've done a great job running {moreThanGoal} more kilometers!");
}
else if (sumOfKilomersPerDay < 1000)
{
    double neededKilometersToGoal = Math.Ceiling(1000 - sumOfKilomersPerDay);
    Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {neededKilometersToGoal} more kilometers");
}