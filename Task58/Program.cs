// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();
Console.WriteLine("Будем находить произведение двух матриц: ");
Console.Write("Введите количество строк 1-го массива: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1-го массива: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2-го массива: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2-го массива: ");
int columnsB = Convert.ToInt32(Console.ReadLine());
if (columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    return;
}
int[,] A = CreateArray(rowsA, columnsA, 0, 10);
int[,] B = CreateArray(rowsB, columnsB, 0, 10);
Console.WriteLine();
Console.WriteLine("Первая матрица: ");
PrintArray(A);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(B);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц: ");
PrintArray(GetMultiplicationMatrix(A, B));

int[,] CreateArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}