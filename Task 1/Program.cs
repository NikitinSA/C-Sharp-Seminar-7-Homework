﻿/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Clear();

Console.Write("Задайте количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] array = new double[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();


void FillArray(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random rand = new Random();
            array[i, j] = rand.Next(-10, 10) + rand.NextDouble();
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}