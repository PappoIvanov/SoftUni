int peopleCount = int.Parse(Console.ReadLine());
int nightsCount =  int.Parse(Console.ReadLine());
int transportCards = int.Parse(Console.ReadLine());
int museumTickets = int.Parse(Console.ReadLine());

double nightsTax = 20;
double transportCardPrice = 1.60;
double museumTicketsPrice = 6;

double taxForPerson = nightsCount *  nightsTax + transportCards * transportCardPrice + museumTickets * museumTicketsPrice;
double groupTax = taxForPerson * peopleCount * 1.25;

Console.WriteLine($"{groupTax:f2}");