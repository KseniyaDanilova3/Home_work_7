// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int height = EnterInt("Введите количество строк в массиве:  ");
int width  = EnterInt("Введите количество стобцов в массиве: ");

int[ , ] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
ArithmeticalMean(numbers, height, width);

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
            numbers[i, j] = new Random ().Next (-10, 11);
        }
    }
}

void Print2DArray (int[, ] numbers, int height, int width)
{
    for (int i = 0; i < height; i++) 
    {
        for (int j = 0; j < width; j++) 
        {
            Console.Write ($"{numbers[i, j],3} ");
        }
        Console.WriteLine ();
    }
}
void ArithmeticalMean(int[, ] numbers, int height, int width)
{
    for (int j = 0; j < width; j++)
    {
        double sum = 0;
        for (int i = 0; i < height; i++)
        {
            sum += numbers[i, j];
        }
        double average = sum / height;
        Console.WriteLine($"среднее арифметическое числел в {j} столбце = {average:f2}");
    }
}