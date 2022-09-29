int height = 4;
int width = 4;
int[,] Array = new int[height, width];
FeelMass(height, width);
while (CheckFeeld(height, width))
{
    PlaceRnd(height, width);
    PrintFeeld(height, width);
    ShakFeeld(height, width); 
}
Console.ReadLine();

void FeelMass(int height, int width)
{
    for (int i = 0; i < height; i++)
        for (int j = 0; j < width; j++)
            Array[i, j] = 0;
}

bool CheckFeeld(int width, int height)
{
    for (int i = 0; i < height; i++)
        for (int k = 0; k < width; k++)
            if (Array[i, k] == 0)
                return true;
    for (int i = 0; i < height - 1; i++)
        for (int k = 0; k < width - 1; k++)
            if (Array[i, k] == Array[i, k + 1] || Array[k, i] == Array[k + 1, i]);
                return true;
    Console.ReadLine();
    return false;
}

void PrintFeeld(int width, int height)
{
    Console.WriteLine();
    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            Console.Write(Array[i, j]);
        }
        Console.WriteLine();
    }
    return;
}

void PlaceRnd(int width, int height)
{
    Random rnd = new Random();
    int RandW;
    int RandH;
    do
    {
        RandW = rnd.Next(0, width);
        RandH = rnd.Next(0, height);
    } while (Array[RandW, RandH] != 0);
    Array[RandW, RandH] = 2;
}

void ShakFeeld(int width, int height)
{
    int a = 0;
    Console.WriteLine("Двигайся");
    while (a == 0)
    {
        switch (Console.Read() - 48)
        {
            case 4:
                MoveLeft(width, height);
                a++;
                break;
            case 6:
                MoveRight(width, height);
                a++;
                break;
            case 2:
                MoveDown(width, height);
                a++;
                break;
            case 8:
                MoveUp(width, height);
                a++;
                break;
        }
    }


}

void MoveLeft(int width, int height)                                                    //Сдвинуть влево
{
    int container;
    for (int i = 0; i < height; i++)                                                     //Объединение
    {
        container = 0;
        for (int k = container + 1; k < width; k++)
        {
            if (Array[i, k] == Array[i, container] && Array[i, k] != 0)
            {
                Array[i, container] *= 2;
                Array[i, k] = 0;
                container = k;
            }
            else if (Array[i, k] != 0 && Array[i, k] != Array[i, container])
            {
                container = k;
            }
        }
        container = 0;
        while (Array[i, container] != 0 && container < width - 1)
        {
            container++;
        }
        for (int k = container + 1; k < width; k++)
        {
            if (Array[i, k] != 0)
            {
                Array[i, container] = Array[i, k];
                Array[i, k] = 0;
                container = k;
            }
        }
    }
    return;
}

void MoveRight(int width, int height)                                                   //Сдвинуть вправо
{
    int container;
    for (int i = 0; i < height; i++)                                                     //Объединение
    {
        container = width - 1;
        for (int k = container - 1; k >= 0; k--)
        {
            if (Array[i, k] == Array[i, container] && Array[i, k] != 0)
            {
                Array[i, container] *= 2;
                Array[i, k] = 0;
                container = k;
            }
            else if (Array[i, k] != 0 && Array[i, k] != Array[i, container])
            {
                container = k;
            }
        }
        container = width - 1;
        while (Array[i, container] != 0 && container > 0)
        {
            container--;
        }
        for (int k = container - 1; k >= 0; k--)
        {
            if (Array[i, k] != 0)
            {
                Array[i, container] = Array[i, k];
                Array[i, k] = 0;
                container = k;
            }
        }
    }
    return;
}

void MoveUp(int width, int height)                                                    //Сдвинуть влево
{
    int container;
    for (int i = 0; i < height; i++)                                                     //Объединение
    {
        container = 0;
        for (int k = container + 1; k < width; k++)
        {
            if (Array[k, i] == Array[container, i] && Array[k, i] != 0)
            {
                Array[container, i] *= 2;
                Array[k, i] = 0;
                container = k;
            }
            else if (Array[k, i] != 0 && Array[k, i] != Array[container, i])
            {
                container = k;
            }
        }
        container = 0;
        while (Array[i, container] != 0 && container < width - 1)
        {
            container++;
        }
        for (int k = container + 1; k < width; k++)
        {
            if (Array[k, i] != 0)
            {
                Array[container, i] = Array[k, i];
                Array[k, i] = 0;
                container = k;
            }
        }
    }
    return;
}


void MoveDown(int width, int height)                                                   //Сдвинуть вправо
{
    int container;
    for (int i = 0; i < height; i++)                                                     //Объединение
    {
        container = width - 1;
        for (int k = container - 1; k >= 0; k--)
        {
            if (Array[k, i] == Array[container, i] && Array[k, i] != 0)
            {
                Array[container, i] *= 2;
                Array[k, i] = 0;
                container = k;
            }
            else if (Array[k, i] != 0 && Array[k, i] != Array[container, i])
            {
                container = k;
            }
        }
        container = width - 1;
        while (Array[container, i] != 0 && container > 0)
        {
            container--;
        }
        for (int k = container - 1; k >= 0; k--)
        {
            if (Array[k, i] != 0)
            {
                Array[container, i] = Array[k, i];
                Array[k, i] = 0;
                container = k;
            }
        }
    }
    return;
}