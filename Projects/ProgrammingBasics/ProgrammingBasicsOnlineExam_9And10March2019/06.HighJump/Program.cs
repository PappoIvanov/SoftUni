using System;

namespace _06.HighJump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingGoalHight = int.Parse(Console.ReadLine());
            int currentGoalHight = startingGoalHight - 30;
            int badTriesCounter = 0;
            int jumpsCounter = 0;
            bool goalReached = false;

            while (startingGoalHight >= currentGoalHight)
            {
                
                int nextJump = int.Parse(Console.ReadLine());

                if (nextJump > currentGoalHight)
                {
                    jumpsCounter++;
                    if (currentGoalHight >= startingGoalHight) { goalReached = true; break; }
                    currentGoalHight += 5;
                    badTriesCounter = 0;
                }
                else if (nextJump <= currentGoalHight)
                {
                    badTriesCounter++;
                    jumpsCounter++;

                    if (badTriesCounter == 3) { Console.WriteLine($"Tihomir failed at {currentGoalHight}cm after {jumpsCounter} jumps."); break; }
                }
            }
            if (goalReached) { Console.WriteLine($"Tihomir succeeded, he jumped over {currentGoalHight}cm after {jumpsCounter} jumps."); }

        }
    }
}
