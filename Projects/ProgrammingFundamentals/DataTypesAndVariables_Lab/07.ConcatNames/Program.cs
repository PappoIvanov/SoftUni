string firstName = Console.ReadLine();
string lastName = Console.ReadLine();
string delimeter = Console.ReadLine();

//Console.WriteLine($"{firstName}{delimeter}{lastName}");
Console.WriteLine("{0}" + "{2}" + "{1}", firstName, lastName, delimeter);