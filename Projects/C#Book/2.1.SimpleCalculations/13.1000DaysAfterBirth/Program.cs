using System;
using System.Globalization;

namespace _13._1000DaysAfterBirth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string birthDate = Console.ReadLine();
            string format = "dd-MM-yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime date = DateTime.ParseExact(birthDate, format, provider);
            date = date.AddDays(1000);
            Console.WriteLine("{0}", date.ToString(format));
        }
    }
}
