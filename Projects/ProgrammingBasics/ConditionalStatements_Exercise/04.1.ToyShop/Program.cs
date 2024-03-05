//•	Пъзел - 2.60 лв.
//•	Говореща кукла - 3 лв.
//•	Плюшено мече - 4.10 лв.
//•	Миньон - 8.20 лв.
//•	Камионче - 2 лв.

double priceOfExcursion = double.Parse(Console.ReadLine());
int puzzle = int.Parse(Console.ReadLine());
int doll = int.Parse(Console.ReadLine());
int bear = int.Parse(Console.ReadLine());
int minion = int.Parse(Console.ReadLine());
int truck = int.Parse(Console.ReadLine());

double countOfToys = puzzle + doll + bear + minion + truck;
double puzzlePrice = puzzle * 2.60;
int dollPrice = doll * 3;
double bearPrice = bear * 4.10;
double minionPrice = minion * 8.20;
int truckPrice = truck * 2;

double sumOfToys = 0;
if  (countOfToys >= 50)
{
    sumOfToys = (puzzlePrice + dollPrice + bearPrice + minionPrice + truckPrice) * 0.75;
}
else
{
    sumOfToys = puzzlePrice + dollPrice + bearPrice + minionPrice + truckPrice;
}
double rent = sumOfToys * 0.1;
double sum = sumOfToys - rent;
if  (sum >= priceOfExcursion)
{
    double moneyLeft = sum - priceOfExcursion;
    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
}
else
{
    double neededMoney = priceOfExcursion - sum;
    Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
}