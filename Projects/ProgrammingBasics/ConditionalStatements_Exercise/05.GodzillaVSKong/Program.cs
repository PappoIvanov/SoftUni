// Разискване на задачата
// 1. Бюджет за филма – реално число в интервала
double budget = double.Parse(Console.ReadLine());

// 2. Брой на статистите – цяло число в интервала
int supernumerary = int.Parse(Console.ReadLine());

// 3. Цена за облекло на един статист – реално число в интервала
double costumePrice = double.Parse(Console.ReadLine());

//Декорът за филма е на стойност 10% от бюджета.
double decor = budget * 0.1;

double costumes = supernumerary * costumePrice;
//При повече от 150 статиста, има отстъпка за облеклото на стойност 10%
if (supernumerary > 150)
{
    costumes = costumes * 0.9;
}

// ИЗХОД НА КОНЗОЛАТ
// На конзолата трябва да се отпечатат два реда:
// 1. Ако парите за декора и дрехите са повече от бюджета: "Not enough money!"
// o "Wingard needs {парите недостигащи за филма} leva more."
if (decor + costumes > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {(costumes + decor) - budget:f2} leva more.");
}

// 2. Ако парите за декора и дрехите са по малко или равни на бюджета: "Action!"
// o "Wingard starts filming with {останалите пари} leva left."
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget - (costumes + decor):f2} leva left.");
}
//Резултатът трябва да е форматиран до втория знак след десетичната запетая.