// Напишите программу, которая на вход принимает 2 числа и вадает, какое число большее, а какое меньшее.

Console.Write("Введите число №1 ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2 ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA>numberB)
{
    Console.WriteLine($"Максимальное число {numberA} , а минимальное число {numberB}");
}
else
{
    Console.WriteLine($"Максимальное число {numberB} , а минимальное число {numberA}");
}