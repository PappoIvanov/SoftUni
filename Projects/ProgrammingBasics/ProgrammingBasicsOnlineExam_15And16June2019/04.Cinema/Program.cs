//using System;

//namespace _04.Cinema
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int capacityOfHall = int.Parse(Console.ReadLine());
//            string countOfPeopleOrMovieTime = Console.ReadLine();
//            int freeSpaces = capacityOfHall;
//            int peopleCount = 0;
//            int totalIncome = 0;
//            bool isTimeForWatching = false;

//            while (freeSpaces > 0 && countOfPeopleOrMovieTime != "Movie time!") 
//            {
//                // We can skip the boolean, it is not necessary, but we have to get used to it.
//                if (countOfPeopleOrMovieTime == "Movie time!")
//                {
//                    isTimeForWatching = true;
//                    Console.WriteLine($"There are {freeSpaces} seats left in the cinema.");
//                    break;
//                }

//                peopleCount = int.Parse(countOfPeopleOrMovieTime);
//                int sumForTickets = peopleCount * 5;

//                if (peopleCount % 3 == 0) { sumForTickets -= 5; }

//                totalIncome += sumForTickets;
//                sumForTickets = 0;

//                freeSpaces -= peopleCount;

//                //if (freeSpaces < 0)
//                //{
//                //    Console.WriteLine("The cinema is full.");
//                //    break;
//                //}

//                countOfPeopleOrMovieTime = Console.ReadLine();
//            }

//            if (countOfPeopleOrMovieTime == "Movie time!")
//            {
//                //    isTimeForWatching = true;
//                Console.WriteLine($"There are {freeSpaces} seats left in the cinema.");
//            }

//            if (freeSpaces <= 0 && isTimeForWatching)
//            {
//                Console.WriteLine("The cinema is full.");

//            }

//            Console.WriteLine($"Cinema income - {totalIncome} lv.");
//        }
//    }
//}


using System;

namespace _04.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int capacityOfHall = int.Parse(Console.ReadLine());
            int freespaces = capacityOfHall;
            int income = 0;
            bool hallIsFull = false;

            while (freespaces > 0)
            {
                string peopleCountOrMovieTime = Console.ReadLine();

                while (peopleCountOrMovieTime != "Movie time!")
                {

                    int countOfPeople = int.Parse(peopleCountOrMovieTime);
                    
                    if (freespaces < countOfPeople) { hallIsFull = true; break; }
                    int sumForTickets = countOfPeople * 5;

                    if (countOfPeople % 3 == 0)
                    {
                        sumForTickets -= 5;
                    }

                    income += sumForTickets;
                    sumForTickets = 0;

                    freespaces -= countOfPeople;
                   
                    if (peopleCountOrMovieTime == "Movie time!") { break; }
                    else if (freespaces < 0)
                         {
                            hallIsFull = true;
                            break;
                         }

                    peopleCountOrMovieTime = Console.ReadLine();
                }

                if (peopleCountOrMovieTime == "Movie time!") { Console.WriteLine($"There are {freespaces} seats left in the cinema."); break; }
                if (hallIsFull) { Console.WriteLine("The cinema is full."); break; }
                
            }

            Console.WriteLine($"Cinema income - {income} lv.");
        }
    }
}
