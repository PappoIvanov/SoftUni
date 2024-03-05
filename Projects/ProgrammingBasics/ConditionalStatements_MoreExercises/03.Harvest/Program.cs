
int vineyard = int.Parse(Console.ReadLine());
double grapeOfSqMeter = double.Parse(Console.ReadLine());
int wineForSale = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());


double sumOfGrape = vineyard * grapeOfSqMeter;
double grapeForWine = sumOfGrape * 0.40;
double wine = (grapeForWine / 2.5);

if (wine >= wineForSale)
{
    double wineLeft = Math.Ceiling(wine - wineForSale);
    double wineForWorker = Math.Ceiling(wineLeft / workers);
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Ceiling(wine)} liters.");
    Console.WriteLine($"{wineLeft} liters left -> {wineForWorker} liters per person.");
}
else if (wine < wineForSale)
{
    double neededWine = wineForSale - wine;
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine)} liters wine needed.");
}