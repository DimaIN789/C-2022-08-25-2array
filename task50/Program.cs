// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


Console.WriteLine("Задайте через Enter номер строки и столбца искомого элемента  ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(5, 5);
PrintMatrix(matrix);
SearchElement(matrix);

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("________________");
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("________________");
}

void SearchElement(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == m - 1 && j == n - 1)
            {
                matrix[i, j] = matrix[m - 1, n - 1];
                Console.WriteLine($"это элемент {matrix[m - 1, n - 1]}");
            }
            // if (i > m - 1 || i < m - 1 || j > n - 1 || j < n - 1)
            // {
            //     Console.WriteLine("такого числа в массиве нет");
            // }
        }
    }
}


