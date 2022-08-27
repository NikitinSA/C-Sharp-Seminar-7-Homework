/*Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же 
указание, что такого элемента нет.(на вход именно поступает позиция 
элемента, можете разбить на две переменные или прописать в одну 
строку и конвертировать в два числа, комментарии в конце семинара 
по этой задаче)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Clear();

Console.Write("Введите индекс элемента в строке двумерного массива: ");
int indexLine = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс элемента в столбце двумерного массива: ");
int indexColumn = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[10, 10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Число равное заданным позициям {FindingNumber(array, indexLine, indexColumn)}");

void FillArray(int[,] array)
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
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

int FindingNumber(int[,] array, int indexLine, int indexColumn)
{
    int res = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (indexLine == j && indexColumn == i)
            {
                res = array[i, j];
            }
        }
    }
    return res;
}