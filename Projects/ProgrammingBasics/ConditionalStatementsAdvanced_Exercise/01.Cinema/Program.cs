namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int colums = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            int countOfSeats = colums * rows;

            switch (movie)
            {
                case "Premiere": Console.WriteLine($"{(double)countOfSeats * 12:f2} leva"); ; break;
                case "Normal": Console.WriteLine($"{(double)countOfSeats * 7.50:f2} leva"); break;
                case "Discount": Console.WriteLine($"{(double)countOfSeats * 5.00:f2} leva"); break;
            }
        }
    }
}