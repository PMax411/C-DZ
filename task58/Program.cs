// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j], 4} ");
        }

        Console.Write("|");
        Console.WriteLine();
    }
}
int[,] MatrixMult(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] matrixMult = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < matrixMult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMult.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            matrixMult[i, j] = sum;
            sum = 0;
        }
    }
    return matrixMult;
}

bool Compare(int[,] firstMatrix, int[,] secondMatrix)
{
    return (firstMatrix.GetLength(1) != secondMatrix.GetLength(0));
}

int[,] array2dFirst = CreateMatrix(4, 4, 1, 2);
int[,] array2dSecond = CreateMatrix(4, 3, 1, 3);
Console.WriteLine("Первая матрица");
PrintMatrix(array2dFirst);
Console.WriteLine("Вторая матрица");
PrintMatrix(array2dSecond);
Console.WriteLine();
if (Compare(array2dFirst, array2dSecond))
{
    Console.WriteLine("Произведение матриц возможно в случае, если число столбцов матрицы P равняется числу строк матрицы K. В указанном случае это условие не выполняется.");
    return;
}
Console.WriteLine("Произведение матриц:");
int[,] result = MatrixMult(array2dFirst, array2dSecond);
PrintMatrix(result);