Dictionary<int, char> AlphabetDecod = new Dictionary<int, char>();   //ключи к дешифровке
Dictionary<char, int> AlphabetCod = new Dictionary<char, int>();
int aStart = 97;                                                //начало алфавита 
int aLong = 26;                                                 //длина алфавита
int number;                                                     //делимое
int del = 2;                                                    //делитель
int count = 0;                                                  //Номер заполнения
string text;                                                    
int[] simple = new int[26];
simple[0] = 2;                                                  //Массив простых чисел
List<int> Cod = new List<int>();
List<string> Decod = new List<string>();

GetAlphabet();
PrintAlphabet();
Console.ReadKey();
while (true)
{
    ConvertText();
    ConvertCod();
}

void ConvertCod()
{
    Decod.Clear();
    foreach (int i in Cod)
    {
        Decod.Add("");
        count = 0;
        number = i;
        del = 2;
        while (number != 1)
        {
            if (number % del == 0)
            {
                number /= del;
                Decod[count] += (AlphabetDecod[del]);
            }
            else
            {
                del++;
            }
        }
    }
    Console.WriteLine();
    foreach (string s in Decod)
    {
        Console.WriteLine(s);  
    }

}

void ConvertText()
{
    count = 0;
    Cod.Clear();
    Cod.Add(1);
    Console.WriteLine("Введите текст");
    text = Console.ReadLine();
    foreach (char c in text)
    {
        if (c == ' ')
        {
            Cod.Add(1);
            count++;
        }
        else if (Convert.ToChar(aStart) <= c && c < Convert.ToChar(aStart + aLong))
        {
            Cod[count] *= AlphabetCod[c];
        }
    }
    Console.WriteLine();
    foreach (int i in Cod)
    {
        Console.Write(i + " ");
    }
}

void PrintAlphabet()
{
    foreach (var temp in AlphabetCod)
    {
        Console.WriteLine(temp);
    }
    foreach (var temp in AlphabetDecod)
    {
        Console.WriteLine(temp);
    }
}

void GetAlphabet()
{
    int f = 1;
    number = simple[0];
    while (count < aLong)
    {
        while (number >= del)
        {
            if (number % del == 0 && del != number)            //если не простое число
            {
                number++;
                break;
            }
            else if(del == number)                  //если простое число
            {     
                AlphabetDecod[number] = Convert.ToChar(aStart + count);
                AlphabetCod[Convert.ToChar(aStart + count)] = number;
                simple[count] = number;
                count++;
                number++;
                break;
            }
            else
            {
                if (f < simple.Length && simple[f] != 0)
                {
                    del = simple[f];
                    f++;
                }
                else
                    del++;
            }
        }
        del = simple[0];
        f = 1;
    }
}



//for (int i = 0; i < aLong; i++)
//{
//    while (number != 1)
//    {
//        if (number % del == 0)
//        {
//            number /= del;
//            gnom.Add(del);
//        }
//        else
//        {
//            del++;
//        }
//    }
//}

//int number;
//List<int> gnom = new List<int>();
//Random random = new Random();
//int del;
//number = random.Next(20, 100);
//while (true)
//{
//    gnom.Clear();
//    Console.Clear();
//    number = random.Next(20, 100);
//    del = 2;
//    Console.WriteLine(number);
//    Console.WriteLine();
//    while (number != 1)
//    {
//        if (number % del == 0)
//        {
//            number /= del;
//            gnom.Add(del);
//        }
//        else
//        {
//            del++;
//        }
//    }
//    //for (int i = 0; i < gnom.Count; i++)
//    //{
//    //    Console.WriteLine(gnom[i]);
//    //}
//    Console.ReadKey();
//}