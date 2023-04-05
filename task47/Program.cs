// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixDouble(int rows, int column, double min, double max)
{
    double[,] matrix = new double[rows, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double tempDigit = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(tempDigit, 1);
        }
    }
    return matrix;
}

void Printarray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 7} ");
        }
        Console.WriteLine("]");
    }
}
double[,] arr2d = CreateMatrixDouble(3, 4, -100, 100);
Printarray(arr2d);
