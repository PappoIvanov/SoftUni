int magnolii = int.Parse(Console.ReadLine());
int ziumbiuli = int.Parse(Console.ReadLine());
int rozes = int.Parse(Console.ReadLine());
int cactuses = int.Parse(Console.ReadLine());
double presentPrice = double.Parse(Console.ReadLine());

double magnoliiSum = magnolii * 3.25;
double ziumbiuliSum = ziumbiuli * 4.00;
double rozesSum = rozes * 3.50;
double cactusesSum = cactuses * 8.00;
double sumOfFlallorse = magnoliiSum + ziumbiuliSum + rozesSum + cactusesSum;
double taxes = sumOfFlallorse * 0.05;
double profit = sumOfFlallorse - taxes;

if (profit > presentPrice)
{
    double moneyLeft = Math.Floor(profit - presentPrice);
    Console.WriteLine($"She is left with {moneyLeft} leva.");
}
else
{
    double neededMoney = Math.Ceiling(presentPrice - profit);
    Console.WriteLine($"She will have to borrow {neededMoney} leva.");
}