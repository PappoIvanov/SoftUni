namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int elevatroCapacity = int.Parse(Console.ReadLine());

            double coursesCount = Math.Ceiling((double)countOfPeople / elevatroCapacity);
            Console.WriteLine(coursesCount);
        }
    }
}
