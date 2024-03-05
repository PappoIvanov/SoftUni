using System;

namespace _04.CinemaVoucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voucherValue = int.Parse(Console.ReadLine());

            string boughtName = Console.ReadLine();
            int symbolCount = boughtName.Length;
            int sumOfSymbols = 0;
            int boughtTicketsCounter = 0;
            int otherProductsBought = 0;
            bool noMoneyLeft = false;

            while (boughtName != "End")
            {
                if (symbolCount > 8) 
                {
                    char firstSymbol = boughtName[0];
                    char secondSymbol = boughtName[1];

                    int firstSymbolValue = (int)firstSymbol;
                    int secondSymbolValue = (int)secondSymbol;
                    sumOfSymbols = firstSymbolValue + secondSymbolValue;
                    voucherValue -= sumOfSymbols;
                    if (voucherValue < 0)
                    {
                        noMoneyLeft = true;
                        break;
                    }
                    boughtTicketsCounter++;

                }
                else if (symbolCount <= 8)
                {
                    char firstSymbol = boughtName[0];
                    int firstSymbolValue = (int)firstSymbol;
                    sumOfSymbols += firstSymbolValue;
                    voucherValue -= sumOfSymbols;
                    if (voucherValue < 0)
                    {
                        noMoneyLeft = true;
                        break;
                    }
                    otherProductsBought++;
                }

                sumOfSymbols = 0;

                boughtName = Console.ReadLine();
                symbolCount = boughtName.Length;

            }

            Console.WriteLine(boughtTicketsCounter);
            Console.WriteLine(otherProductsBought);
        }
    }
}
