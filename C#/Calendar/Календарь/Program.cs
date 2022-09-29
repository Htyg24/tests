const int month = 12;
int[][] year = new int[month][];
int yearNumber;
string[] MonthName = new string[month] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "Novebmer", "December" };
const int week = 7;
int step = 0;
Console.WriteLine("Какой год вам нужен?");
yearNumber = int.Parse(Console.ReadLine());
step = ((yearNumber - 1900) * 365 + ((yearNumber - 1901) / 4)) % week;
GetYear(year, yearNumber, month);
PrintYear(year, month, step, MonthName);
void PrintYear(int[][] year, int month, int step, string[] MonthName)
{
    Console.Clear();
    Console.WriteLine(yearNumber);
    int day = step;
    for (int i = 0; i < year.Length; i++)
    {
        Console.WriteLine("\n \n" + MonthName[i] + "\n" + "Mn Ts Th Wn Fr St Sn");
        for (int j = 0; j < day; j++)
            Console.Write("   ");
        for (int j = 0; j < year[i].Length; j++)
        {
            Console.Write(j + 1 + " ");
            if (j + 1 < 10)
                Console.Write(" ");
            day++;
            if (day == week)
            {
                Console.WriteLine();
                day = 0;
            }
        }
    }
}

Array GetYear(int[][] year, int yearNumber, int month)
{
    for (int i = 0; i < month; i++)
    {
        int monthLenght = 31 - i % 2;
        if (i == 1)
        {
            if (yearNumber % 4 == 0)
                monthLenght = 29;
            else
                monthLenght = 28;
        }
        if (i > 5)
        {
            monthLenght = 30 + i % 2;
        }

        year[i] = new int[monthLenght];
    }
    return year;
}