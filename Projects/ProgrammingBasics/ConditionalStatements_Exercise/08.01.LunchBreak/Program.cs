
string movie = Console.ReadLine();
int timeOfMovie = int.Parse(Console.ReadLine());
int timeOfBreak =  int.Parse(Console.ReadLine());

double lunchTime = timeOfBreak / 8.0;
double timeOfRest = timeOfBreak / 4.0;

double timeForWatching = (timeOfBreak - (lunchTime + timeOfRest));

if (timeForWatching >= timeOfMovie)
{
    double leftTime = (timeForWatching - timeOfMovie);
    Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(leftTime)} minutes free time.");
}
else
{
    double neededTime = (timeOfMovie - timeForWatching);
    Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(neededTime)} more minutes.");
}