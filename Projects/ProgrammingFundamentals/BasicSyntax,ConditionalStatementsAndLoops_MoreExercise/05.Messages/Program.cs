using System;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countOfdiDigits = int.Parse(Console.ReadLine());
            string word = "";
            

            for (int i = 0; i < countOfdiDigits; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                int counter = 0, currentDigit = 0;

                while (currentNumber > 0)
                {
                    currentDigit = currentNumber % 10;
                    currentNumber /= 10;
                    counter++;
                }

                if (currentDigit == 2)
                {
                    switch (counter)
                    {
                        case 1: word += "a"; break;
                        case 2: word += "b"; break;
                        case 3: word += "c"; break;
                    }
                }
                else if (currentDigit == 3)
                {
                    switch (counter)
                    {
                        case 1: word += "d"; break;
                        case 2: word += "e"; break;
                        case 3: word += "f"; break;
                    }
                }
                else if (currentDigit == 4)
                {
                    switch (counter)
                    {
                        case 1: word += "g"; break;
                        case 2: word += "h"; break;
                        case 3: word += "i"; break;
                    }
                }
                else if (currentDigit == 5)
                {
                    switch (counter)
                    {
                        case 1: word += "j"; break;
                        case 2: word += "k"; break;
                        case 3: word += "l"; break;
                    }
                }
                else if (currentDigit == 6)
                {
                    switch (counter)
                    {
                        case 1: word += "m"; break;
                        case 2: word += "n"; break;
                        case 3: word += "o"; break;
                    }
                }
                else if (currentDigit == 7)
                {
                    switch (counter)
                    {
                        case 1: word += "p"; break;
                        case 2: word += "q"; break;
                        case 3: word += "r"; break;
                        case 4: word += "s"; break;
                    }
                }
                else if (currentDigit == 8)
                {
                    switch (counter)
                    {
                        case 1: word += "t"; break;
                        case 2: word += "u"; break;
                        case 3: word += "v"; break;
                    }
                }
                else if (currentDigit == 9)
                {
                    switch (counter)
                    {
                        case 1: word += "w"; break;
                        case 2: word += "x"; break;
                        case 3: word += "y"; break;
                        case 4: word += "z"; break;
                    }
                }
                else if (currentDigit == 0)
                {
                    word += " ";
                }
            }
            Console.WriteLine(word);
        }
    }
}
