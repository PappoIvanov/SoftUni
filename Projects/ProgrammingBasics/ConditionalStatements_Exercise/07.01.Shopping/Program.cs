
double budget = double.Parse(Console.ReadLine());
int videocard =  int.Parse(Console.ReadLine());
int processor = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

double videocardPrice = 250;
double processorPrice = (videocardPrice * videocard) * 0.35;
double ramPrice = (videocardPrice * videocard) * 0.1;

double sum = (videocard * videocardPrice) + (processor * processorPrice) + (ram * ramPrice);
if (videocard > processor)
{
    sum -= sum * 0.15;
}

if (budget >= sum)
{
    double moneyLeft = budget - sum;
    Console.WriteLine($"You have {moneyLeft:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva more!");
}