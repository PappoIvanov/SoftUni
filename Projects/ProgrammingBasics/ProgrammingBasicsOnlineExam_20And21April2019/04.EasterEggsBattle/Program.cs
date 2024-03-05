//using System;

//namespace _04.EasterEggsBattle
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int firstPlayerEggs = int.Parse(Console.ReadLine());
//            int secondPlayerEggs = int.Parse(Console.ReadLine());
//            string command = Console.ReadLine();
//            bool noMoreEggs = false;

//            while (command != "End")
//            {
//                switch (command)
//                {
//                    case "one": secondPlayerEggs--; 
//                        if (secondPlayerEggs == 0)
//                        {
//                            Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
//                            noMoreEggs = true;
//                            break;
//                        } break;
//                    case "two": firstPlayerEggs--;
//                        if (firstPlayerEggs == 0)
//                        {
//                            Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
//                            noMoreEggs = true;
//                            break;
//                        } break;
//                }

//                if (noMoreEggs) break;

//                command = Console.ReadLine();
//            }

//            if (!noMoreEggs)
//            {
//                Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
//                Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
//            }
//        }
//    }
//}


using System;

namespace _05.EasterEggsBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int playerOneEggsCount = int.Parse(Console.ReadLine());
            int playerTwoEggsCount = int.Parse(Console.ReadLine());

            //Calculation
            while (true)
            {
                string endCommandOrWinner = Console.ReadLine();
                if (endCommandOrWinner == "End")
                {
                    Console.WriteLine($"Player one has {playerOneEggsCount} eggs left.");
                    Console.WriteLine($"Player two has {playerTwoEggsCount} eggs left.");
                    break;
                }

                if (endCommandOrWinner == "one")
                {
                    playerTwoEggsCount--;
                    if (playerTwoEggsCount == 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {playerOneEggsCount} eggs left.");
                        break;
                    }
                }
                else if (endCommandOrWinner == "two")
                {
                    playerOneEggsCount--;
                    if (playerOneEggsCount == 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {playerTwoEggsCount} eggs left.");
                        break;
                    }
                }
            }
        }
    }
}
