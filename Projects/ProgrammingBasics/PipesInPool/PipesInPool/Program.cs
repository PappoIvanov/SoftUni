
int poolVolume = int.Parse(Console.ReadLine());
int pipe1 = int.Parse(Console.ReadLine());
int pipe2  = int.Parse(Console.ReadLine());
double N = double.Parse(Console.ReadLine());

double debitPipe1 = pipe1 * N;
double debitPipe2 = pipe2 * N;
double generalDebit =  debitPipe1 + debitPipe2;

if  (generalDebit < poolVolume)
{
    double fullness = (generalDebit / poolVolume) * 100;
    double pipe1Percentage = (debitPipe1 / generalDebit) * 100;
    double pipe2Percentage = (debitPipe2 / generalDebit) * 100;
    Console.WriteLine($"The pool is {fullness:f2}% full. Pipe 1: {pipe1Percentage:f2}%. Pipe 2: {pipe2Percentage:f2}%.");
}
else
{
    double fullness = generalDebit - poolVolume;
    Console.WriteLine($"For {N:f2} hours the pool overflows with {fullness:f2} liters.");
}