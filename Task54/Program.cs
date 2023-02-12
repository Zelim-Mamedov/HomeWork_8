// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine("Отсортированные строки массива: ");
SortArrayRows(array2D);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void SortArrayRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] <= matrix[i, k]) continue;
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = temp;
            }

    for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,4}", matrix[i, j]);
        }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Заданный массив: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
            {
                Console.Write($"{matrix[i, j],2} | ");
            }
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine("");
}