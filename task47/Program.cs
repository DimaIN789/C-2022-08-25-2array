﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число строк и число столбцов через Enter ");
int m = Convert.ToInt32(Console.ReadLine());//число строк
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
double[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);

double[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    double[,] matrix = new double[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble() * 10;
            matrix[i, j] = Math.Round(matrix[i, j], 1); //округление до нужного числа цифр после запятой:
        }
    }

    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
