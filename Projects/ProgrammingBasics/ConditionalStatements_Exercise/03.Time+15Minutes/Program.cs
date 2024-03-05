int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int allMinutes = minutes + (hours * 60);

allMinutes = allMinutes + 15;

hours = allMinutes / 60;
minutes = allMinutes % 60;


if (hours == 24)
{
    Console.WriteLine($"0:{minutes:d2}");
}
else if (hours < 24)
{
    Console.WriteLine($"{hours}:{minutes:d2}");
}
else
{
    Console.WriteLine("error");
}

//if (minutes < 10)
//{
//    Console.WriteLine($"{hours}:0{minutes}");
//}
//else
//{
//    Console.WriteLine($"{hours}:{minutes}");
//}

/*Решение на Ивет:
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int allMinutes = minutes + (hours * 60);

allMinutes = allMinutes + 15;

hours = allMinutes / 60;
minutes = allMinutes % 60;

bool newDay = hours == 24;

if (newDay)
{
    Console.WriteLine($"0:{minutes:D2}");
}
else
{
    Console.WriteLine($"{hours}:{minutes}");
} */