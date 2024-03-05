namespace _05.specialnumbers
{
    internal class program
    {
        static void main(string[] args)
        {
            int number = int.parse(console.readline());

            for (int numberofcycles = 1111; numberofcycles <= 9999; numberofcycles++)
            {
                int currentnumber = numberofcycles;
                bool isnumberspecial = true;

                while (currentnumber > 0)
                {
                    int lastdigit = currentnumber % 10;

                    if (lastdigit == 0) { isnumberspecial = false; break; }

                    if (number % lastdigit != 0)
                    {
                        isnumberspecial = false;
                        break;
                    }
                    currentnumber /= 10;
                }

                if (isnumberspecial)
                {
                    console.write($"{numberofcycles} ");
                }
            }
        }
    }
}
