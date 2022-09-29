// Нахождение целого числа логорифма
int number_log; // Число для которого ищем логорфм
int base_log;   // Основание логорифма

while (true)
{
    GetLogorifm();
}

// m  = GetLogorifm(c) * x * y

void GetLogorifm(int i = 1, int log = 0)
{
    Console.Clear();
    Console.WriteLine("Введите Число");
    number_log = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите основание логорифма");
    base_log = int.Parse(Console.ReadLine());
    while (i < number_log)
    {
        i *= base_log;          //i = i * base_log;
        log++;
    }
    Console.WriteLine("Логорифм {0} по основанию {1} ровно {2}", number_log, base_log, log);
    Console.ReadKey();
}