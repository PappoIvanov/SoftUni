using System;

namespace _06.Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            decimal electricBills = 0;
            decimal otherBills = 0;
            decimal waterBills = 20;
            decimal internetBills = 15;
            decimal bills = 0;

            for (int i = 1; i <= months; i++)
            {
                decimal electricityBills = decimal.Parse(Console.ReadLine());
                electricBills += electricityBills;
                otherBills = (electricityBills + waterBills + internetBills) * 1.20m;
                bills += otherBills;
            }

            decimal average = (electricBills + (waterBills * months) + (internetBills * months) + bills) / months;
            Console.WriteLine($"Electricity: {electricBills:f2} lv");
            Console.WriteLine($"Water: {waterBills * months:f2} lv");
            Console.WriteLine($"Internet: {internetBills * months:f2} lv");
            Console.WriteLine($"Other: {bills:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
