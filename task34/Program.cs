// Задача 34:
// 1.Задайте массив заполненный случайными положительными трёхзначными числами.
//2. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreatearrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void Printarray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
int[] array = CreatearrayRnd(9, 100, 999);
Printarray(array);
Console.WriteLine();

int result = FindDoubleNumber(array);
Console.WriteLine($"Количество четных чисел в масиве => {result}");

int FindDoubleNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
