// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] array2D = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(array2D);
int index = LineSum(array2D);

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
            {
                Console.Write($"{matrix[i, j], 2} | ");
            }
            else Console.Write($"{matrix[i, j], 2} ");
        }
        Console.WriteLine("|");
    }
}

int LineSum(int[,] matrix)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp += matrix[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = i;
        }
    }
    Console.WriteLine("Строка с наименьшей суммой элементов: № " + index + ". Ее сумма = " + sum);
    return sum;
}