
int poolVolume = int.Parse(Console.ReadLine());
int pipe1 =  int.Parse(Console.ReadLine());
int pipe2  = int.Parse(Console.ReadLine());
double hoursN = double.Parse(Console.ReadLine());

double sumDebitOfPipes = (pipe1 + pipe2) * hoursN;

if (poolVolume >= sumDebitOfPipes)
{
    double percentigeOfFullness = (sumDebitOfPipes / poolVolume) * 100;
    double percentigePipe1 = ((pipe1 * hoursN) / sumDebitOfPipes) * 100;
    double percentigePipe2 = ((pipe2 * hoursN) / sumDebitOfPipes) * 100;
    Console.WriteLine($"The pool is {percentigeOfFullness}% full. Pipe 1: {percentigePipe1:f2}%. Pipe 2: {percentigePipe2:f2}%.");
}
else if (poolVolume < sumDebitOfPipes)
{
    double overflow = (sumDebitOfPipes - poolVolume);
    Console.WriteLine($"For {hoursN} hours the pool overflows with {overflow:f2} liters.");
}