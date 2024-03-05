//На конзолата се въвежда:
// 1. Рекордът в секунди, който Иван трябва да подобри
double worldRecord = double.Parse(Console.ReadLine());
// 2. Разстоянието в метри, което трябва да преплува
double distance = double.Parse(Console.ReadLine());
// 3. Времето в секунди, за което плува разстояние от 1 м.
double time = double.Parse(Console.ReadLine());

double timeIvan = distance * time;
//Да се напише програма, която изчислява дали се е справил със задачата, като се има предвид, че:
// - съпротивлението на водата го забавя на всеки 15 м. с 12.5 секунди.
double waterResistance = Math.Floor(distance / 15);

timeIvan = timeIvan + waterResistance * 12.5;

//double fullTimeIvan = timeIvan + newTime;
//Когато се изчислява колко пъти Иванчо ще се забави, в резултат на съпротивлението на водата,
//- резултатът трябва да се закръгли надолу до най-близкото цяло число.

//Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието
//и разликата спрямо Световния рекорд.

//Отпечатването на конзолата зависи от резултата:
// 1.Ако Иван е подобрил Световния рекорд (времето му е по-малко от рекорда) отпечатваме:
//" Yes, he succeeded! The new world record is {времето на Иван} seconds."
if (timeIvan < worldRecord)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {timeIvan:f2} seconds.");
}
else if (timeIvan >= worldRecord)
{
    double timeneeded = timeIvan - worldRecord;
    Console.WriteLine($"No, he failed! He was {timeneeded:f2} seconds slower.");
}
// 2.Ако НЕ е подобрил рекорда (времето му е по-голямо или равно на рекорда) отпечатваме:
//"No, he failed! He was {недостигащите секунди} seconds slower."

//Резултатът трябва да се форматира до втория знак след десетичната запетая.