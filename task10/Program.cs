// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Getsecondnumber(number);
Console.WriteLine($"Вторая цифра числа {number} -> {result}");

int Getsecondnumber(int num)
{
    int secondDigital = (num / 10) % 10;

    return secondDigital;
}
