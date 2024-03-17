namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First try to solve the problem:

                //int number = int.Parse(Console.ReadLine());
                //int sum = 0;
                //int digit = number;

                //while (number > 0)
                //{
                //    digit = number % 10;
                //    sum += digit;
                //    number /= 10;
                //}
                //Console.WriteLine(sum);

            // Second try to solve the problem:

            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            int finalSum = 0;

            for (int value = 0; value < charArray.Length; value++)
            {
                finalSum += int.Parse(charArray[value].ToString());
            }

            Console.WriteLine(finalSum);
        }
    }
}
