//Входът се състои от четири реда:

//1.Бюджетът на Петър - реално число в интервала [0.0…100000.0]
double budget = double.Parse(Console.ReadLine());
//2.Броят видеокарти - цяло число в интервала [0…100]
int numberOfVideocards = int.Parse(Console.ReadLine());
//3.Броят процесори - цяло число в интервала [0…100]
int numberOfProcessors = int.Parse(Console.ReadLine());
//4.Броят рам памет - цяло число в интервала [0…100]
int numberOfRAM =  int.Parse(Console.ReadLine());


//1.Видеокарта – 250 лв./бр.
int videocardPrice = 250;
//2. Процесор – 35% от цената на закупените видеокарти/бр.
double processorPrice = (videocardPrice * numberOfVideocards) * 0.35;
//3. Рам памет – 10% от цената на закупените видеокарти/бр.
double ramPrice = (videocardPrice * numberOfVideocards) * 0.10;

int sumOfVideocards = videocardPrice * numberOfVideocards;
double sumOfProcessors = processorPrice * numberOfProcessors;
double sumOfRAM = ramPrice * numberOfRAM;
double sumOfAll = sumOfVideocards + sumOfProcessors + sumOfRAM;

if (numberOfVideocards > numberOfProcessors)
{
    sumOfAll = sumOfAll - (sumOfAll * 0.15);
}
if (budget >= sumOfAll)
{
    double moneyLeft = budget - sumOfAll;
    Console.WriteLine($"You have {moneyLeft:f2} leva left!");
}
else
{
    double moneyNeeded = sumOfAll - budget;
    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
}


//Изход
//На конзолата се отпечатва 1 ред, който трябва да изглежда по следния начин:

//· Ако бюджета е достатъчен:
//"You have {остатъчен бюджет} leva left!"

//· Ако сумата надхвърля бюджета:
//"Not enough money! You need {нужна сума} leva more!"

//Резултатът да се форматира до втория знак след десетичната запетая.