//using System.Data.SqlTypes;

//double puzzle = 2.60;
//int doll = 3;
//double bear = 4.10;
//double minion = 8.20;
//int truck = 2;

//double priceOfExcursion = double.Parse(Console.ReadLine());
//int countPuzzles = int.Parse(Console.ReadLine());
//int countDolls  = int.Parse(Console.ReadLine());
//int countBears  = int.Parse(Console.ReadLine());
//int countMinions = int.Parse(Console.ReadLine());
//int countTrucks  = int.Parse(Console.ReadLine());

//double totalSum = (puzzle * countPuzzles) + (doll * countDolls) + (bear * countBears) + (minion * countMinions) + (truck * countTrucks);
//int allToysCount = countPuzzles + countDolls + countBears + countMinions + countTrucks;

//if  (allToysCount >= 50)
//{
//    double finalPrice = totalSum - (totalSum * 0.25);
//    double rent = finalPrice * 0.1;
//    double income = finalPrice - rent;

//    if (income > priceOfExcursion)
//    {
//        double moneyForExcursion = income - priceOfExcursion;
//        Console.WriteLine($"Yes! {moneyForExcursion:f2} lv left.");
//    }
//    else if (income < priceOfExcursion)
//    {
//        double notEnoughtMoney = priceOfExcursion - income;
//        Console.WriteLine($"Not enough money! {notEnoughtMoney:f2} lv needed.");
//    }
//}
//else
//{
//    double finalPrice = totalSum;
//    double rent = finalPrice * 0.1;
//    double income = finalPrice - rent;

//    if (income > priceOfExcursion)
//    {
//        double moneyForExcursion = income - priceOfExcursion;
//        Console.WriteLine($"Yes! {moneyForExcursion:f2} lv left.");
//    }
//    else if (income < priceOfExcursion)
//    {
//        double notEnoughtMoney = priceOfExcursion - income;
//        Console.WriteLine($"Not enough money! {notEnoughtMoney:f2} lv needed.");
//    }
//}

// Решение Ивет:
//double puzzle = 2.60;
//int doll = 3;
//double bear = 4.10;
//double minion = 8.20;
//int truck = 2;

double priceOfExcursion = double.Parse(Console.ReadLine());

int countPuzzles = int.Parse(Console.ReadLine());
int countDolls = int.Parse(Console.ReadLine());
int countBears = int.Parse(Console.ReadLine());
int countMinions = int.Parse(Console.ReadLine());
int countTrucks = int.Parse(Console.ReadLine());

int toysCount = countPuzzles + countDolls + countBears + countMinions + countTrucks;

double money = (countPuzzles * 2.60) + (countDolls * 3) + (countBears * 4.10)
                + (countMinions * 8.20) + (countTrucks * 2);

if (toysCount >= 50)
{
    money = money - money * 0.25;
}

money = money - money * 0.1;

if  (money >= priceOfExcursion)
{
    Console.WriteLine($"Yes! {money - priceOfExcursion:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {priceOfExcursion - money:f2} lv needed.");
}