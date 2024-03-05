//Времето за обяд ще бъде 1/8 от времето за почивка,
//а времето за отдих ще бъде 1/4 от времето за почивка.

//Вход
//От конзолата се четат 3 реда:

//1.Име на сериал – текст
string soapOperaName = Console.ReadLine();
//2. Продължителност на епизод – цяло число в диапазона [10… 90]
int continuanceOfSoapOpera = int.Parse(Console.ReadLine());
//3.Продължителност на почивката – цяло число в диапазона [10… 120
int breakTime = int.Parse(Console.ReadLine());

double timeLeft = (double)breakTime * 5 / 8;

if (timeLeft >= continuanceOfSoapOpera)
{
    timeLeft = Math.Ceiling(timeLeft - continuanceOfSoapOpera);
    Console.WriteLine($"You have enough time to watch {soapOperaName} and left with {timeLeft} minutes free time.");
}
else
{
    double timeNeeded = Math.Ceiling(continuanceOfSoapOpera - timeLeft);
    Console.WriteLine($"You don't have enough time to watch {soapOperaName}, you need {timeNeeded} more minutes.");
}

//Изход
//На конзолата да се изпише един ред:

//· Ако времето е достатъчно да изгледате епизода:
//"You have enough time to watch {име на сериал} and left with {останало време} minutes free time."

//· Ако времето не Ви е достатъчно:
//"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."

//Времето да се закръгли до най-близкото цяло число нагоре.