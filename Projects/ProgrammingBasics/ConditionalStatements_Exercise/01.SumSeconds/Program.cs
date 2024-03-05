int firstCompetitor = int.Parse(Console.ReadLine());
int secondCompetitor  = int.Parse(Console.ReadLine());
int thirdCompetitor = int.Parse(Console.ReadLine());

int sumOfTimes = firstCompetitor + secondCompetitor + thirdCompetitor;

double minutes = sumOfTimes / 60;
double seconds = sumOfTimes % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}