/*Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Clear();

double[,] array = new double[3, 4];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ArithmeticMeanOfAColumn(array);

void FillArray(double[,] array)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanOfAColumn(double[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double res = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            res += array[i, j] / 3;
            res = Math.Round(res, 1);
        }
        Console.Write($"{res}; ");
    }
}