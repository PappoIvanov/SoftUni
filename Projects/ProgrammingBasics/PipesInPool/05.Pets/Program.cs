int days = int.Parse(Console.ReadLine());
int food = int.Parse(Console.ReadLine());
double dogsFood = double.Parse(Console.ReadLine());
double catsFood =  double.Parse(Console.ReadLine());
double turtlesFood = double.Parse(Console.ReadLine());

double foodEatenByDog = dogsFood * days;
double foodEatenByCat = catsFood * days;
double foodEatenByTurtle = turtlesFood * days / 1000;
double eatenFood = foodEatenByDog + foodEatenByCat + foodEatenByTurtle;

if (food > eatenFood)
{
    double foodLeft = Math.Floor(food - eatenFood);
    Console.WriteLine($"{foodLeft} kilos of food left.");
}
else
{
    double neededFood = Math.Ceiling(eatenFood - food);
    Console.WriteLine($"{neededFood} more kilos of food are needed.");
}