//years, days, hours and minutes

byte centuries = byte.Parse(Console.ReadLine());

ushort years = centuries * 100u;
int days = years * 3_652_422 / 10_000;
int hours = days * 24;
int minutes = hours * 60;
Console.WriteLine($"{centuries} centuries = {years} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes");