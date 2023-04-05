// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int [,] CreateMatrix(int rows, int column, int min, int max)
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

void Printarray(int[,]  matrix)
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
int SumDigEl(int[,] matrix){
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    
       
        {
            sum = sum +  matrix[i, i];
        }
    
    return sum;
}
int [,] arr2d = CreateMatrix(3, 4,1 ,10);
Printarray(arr2d);
Console.WriteLine(" ");
int result = SumDigEl(arr2d);
Console.WriteLine($"{result}");