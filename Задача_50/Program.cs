// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int height = EnterInt("Введите количество строк в массиве:  ");
int width  = EnterInt("Введите количество стобцов в массиве: ");

int PositionHeight = EnterInt("Введите позицию строки:  ");
int PositionWidth  = EnterInt("Введите позицию столбца: ");

int[ , ] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
SearchElement(numbers, PositionHeight, PositionWidth);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[, ] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random ().Next (0, 11);
        }
    }
}

void Print2DArray (int[, ] numbers, int height, int width)
{
    for (int i = 0; i < height; i++) // для каждой строки
    {
        for (int j = 0; j < width; j++) // внутри этой строки для каждого столбца
        {
            Console.Write ($"{numbers[i, j],3} ");
        }
        Console.WriteLine ();
    }
}

void SearchElement(int[, ] numbers, int PositionHeight, int PositionWidth)
{
    if (PositionHeight < height && PositionWidth < width )
    {
         Console.WriteLine($"Значение элемента в заданом массиве = {numbers[PositionWidth, PositionHeight]}");
    }
    else
    {
        Console.WriteLine("Элемента с такой позицией в массиве нет!");
    }
}