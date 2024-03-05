int xField = int.Parse(Console.ReadLine());
double yGrape = double.Parse(Console.ReadLine());
int  zWineForSell = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());

double harvest = xField * yGrape;

double wine = (0.4 * harvest / 2.5);

if (wine > zWineForSell)
{
    Math.Floor(wine);
    double wineLeft = Math.Ceiling(wine - zWineForSell);
    double wineForWorker = Math.Ceiling(wineLeft / workers);
    Console.WriteLine($"Good harvest this year! Total wine: {wine} liters.");
    Console.WriteLine($"{wineLeft} liters left -> {wineForWorker} liters per person.");
}
else
{
    double neededWine = Math.Floor(zWineForSell - wine);
    Console.WriteLine($"It will be a tough winter! More {neededWine} liters wine needed.");
}