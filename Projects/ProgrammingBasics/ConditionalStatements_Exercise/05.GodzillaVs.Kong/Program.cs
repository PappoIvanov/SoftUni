
double budget = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double costumePrice = double.Parse(Console.ReadLine());

double decor = budget * 0.1;
double allCostumesPrice = costumePrice * statists;

if (statists > 150)
{
    allCostumesPrice -= allCostumesPrice * 0.1;
}

double sum = allCostumesPrice + decor;
if (budget >= sum)
{
    double moneyLeft = budget - sum;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {sum - budget:f2} leva more.");
}
