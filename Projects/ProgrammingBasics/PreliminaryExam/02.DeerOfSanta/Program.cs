int abcenseDays = int.Parse(Console.ReadLine());
int foodLeft = int.Parse(Console.ReadLine());
double firstDeerEatenFood = double.Parse(Console.ReadLine());
double secondDeerEatenFood = double.Parse(Console.ReadLine());
double thirdDeerEatenFood = double.Parse(Console.ReadLine());

double totalEatenFood = (firstDeerEatenFood + secondDeerEatenFood + thirdDeerEatenFood) * abcenseDays;

if (foodLeft >= totalEatenFood)
{
    double notEatenFood = Math.Floor(foodLeft - totalEatenFood);
    Console.WriteLine($"{notEatenFood} kilos of food left.");
}
else if (foodLeft < totalEatenFood)
{
    double neededFood = Math.Ceiling(totalEatenFood - foodLeft);
    Console.WriteLine($"{neededFood} more kilos of food are needed.");
}