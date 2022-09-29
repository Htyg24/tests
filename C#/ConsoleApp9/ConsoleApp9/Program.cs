int number;
List<int> primeNumbers = new List<int>();
Random random = new Random();
int del;
int chek;
number = random.Next(20, 100);
while (true)
{
    chek = 1;
    primeNumbers.Clear();
    Console.Clear();
    number = random.Next(20, 100);
    del = 2;
    Console.WriteLine(number);
    Console.WriteLine();
    while (number != 1)
    {
        if (number % del == 0)
        {
            number /= del;
            primeNumbers.Add(del);
        }
        else
        {
            del++;
        }
    }
    for (int i = 0; i < primeNumbers.Count; i++)
    {
        Console.WriteLine(primeNumbers[i]);
    }
    for (int i = 0; i < primeNumbers.Count; i++)
    {
        chek *= primeNumbers[i];
    }
    Console.WriteLine("\n" + chek);
    Console.ReadKey();
}