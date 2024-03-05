//using System;

//namespace _03.SumPrimeNonPrime
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string numbersOrStop = Console.ReadLine();
//            int primeNumbersSum = 0, nonPrimeNumbersSum = 0;


//            while (numbersOrStop != "stop")
//            {
//                bool isPrime = true;
//                int currentNumber = int.Parse(numbersOrStop);
//                if (currentNumber < 0) { Console.WriteLine("Number is negative."); isPrime = false; }
//                else if (currentNumber <= 1) { primeNumbersSum += currentNumber; }
//                else if (currentNumber > 1)
//                {
//                    for (int i = 2; i < currentNumber - 1; i++)
//                    {

//                        if (currentNumber % i == 0) { nonPrimeNumbersSum += currentNumber; isPrime = false; break; }
//                    }
//                }
//                if (isPrime) { primeNumbersSum += currentNumber; }

//                numbersOrStop = Console.ReadLine();
//            }

//            Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
//            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersSum}");
//        }
//    }
//}


using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0, compositeSum = 0;

            while (input != "stop")
            {
                int currentNumber = int.Parse(input);

                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    double sqrt = Math.Sqrt(currentNumber);
                    for (int i = 2; i <= sqrt; i++)
                    {
                        if (currentNumber % i == 0)
                        {
                            isPrime = false;
                            compositeSum += currentNumber;
                            break;
                        }
                    }
                    if (isPrime) { primeSum += currentNumber; }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {compositeSum}");
        }
    }
}