int numbers = int.Parse(Console.ReadLine());

for (int currentNumber = 1; currentNumber <= numbers; currentNumber++)
{
    switch (currentNumber)
    {
        case 5:
            Console.WriteLine("5 -> True"); 
            break;
        case 7:
            Console.WriteLine("7 -> True");
            break;
        case 11:
            Console.WriteLine("11 -> True");
            break;
        default:
            Console.WriteLine($"{currentNumber} -> False");
            break;
    }
}