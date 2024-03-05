
double worldRecord = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timeForMeter = double.Parse(Console.ReadLine());
double waterResistance;
double ivanchoSwimingTime = distance * timeForMeter;
double ivanchoTime;

if (distance >= 15)
{
     waterResistance = Math.Floor(distance / 15) * 12.5;
     ivanchoTime = ivanchoSwimingTime + waterResistance;
    if (ivanchoTime < worldRecord)
    {
        Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchoTime:f2} seconds.");
    }
    else
    {
        Console.WriteLine($"No, he failed! He was {ivanchoTime - worldRecord:f2} seconds slower.");
    }

}
else
{
    ivanchoTime = ivanchoSwimingTime;
    if (ivanchoTime < worldRecord)
    {
        Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchoTime:f2} seconds.");
    }
    else
    {
        Console.WriteLine($"No, he failed! He was {ivanchoTime - worldRecord:f2} seconds slower.");
    }
}
