// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrix(int rows, int column, int min, int max)
{
    int[,] matrix = new int[rows, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void Printarray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 8} ");
        }
        Console.WriteLine("]");
    }
}

bool Verification(int[,] matrix, int rows, int colums)
{
    return rows <= matrix.GetLength(0) && colums <= matrix.GetLength(1);
}

int[,] arr2d = CreateMatrix(3, 4, 1, 100);
Printarray(arr2d);
Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int colum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(
    Verification(arr2d, row, colum)
        ? $"В ячейке [{row}, {colum}] находится число {arr2d[row - 1, colum - 1]}"
        : "В массиве нет такого эллемента "
);
