using System;

namespace _06.TournamentOfChristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOfTournament = int.Parse(Console.ReadLine());
            double moneyForCharity = 0, currentDayCharityMoney = 0;
            int winsCounter = 0, lostsCounter = 0, daysWonCounter = 0, daysLostCounter = 0;

            for (int i = 0; i < daysOfTournament; i++)
            {
                string sport = Console.ReadLine();
                while (sport != "Finish")
                {
                    string winOrLost = Console.ReadLine();

                    switch (winOrLost)
                    {
                        case "win": currentDayCharityMoney += 20; winsCounter++; break;
                        case "lose": lostsCounter++; break;
                    }

                    sport = Console.ReadLine();
                }

                if (winsCounter > lostsCounter)
                {
                    currentDayCharityMoney *= 1.10;
                    daysWonCounter++;
                }
                else { daysLostCounter++; }

                winsCounter = 0;
                lostsCounter = 0;

                moneyForCharity += currentDayCharityMoney;
                currentDayCharityMoney = 0;
            }
            
            if (daysWonCounter > daysLostCounter)
            {
                moneyForCharity *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {moneyForCharity:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyForCharity:f2}");
            }

            
        }
    }
}
