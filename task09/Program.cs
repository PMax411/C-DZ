// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из  отрезка 10-99 -> {number} ");
int firstdig = number / 10;
int seconddig = number % 10;

if (firstdig > seconddig)
{
    Console.WriteLine($"Наибольшая цифра число {number} -> {firstdig} ");
}
else
{
    Console.WriteLine($"Наибольшая цифра число {number} -> {seconddig} ");
}

int result = MaxDigit(number);
 Console.WriteLine($"Наибольшая цифра число {result}");

int MaxDigit(int num)
{
    int firstdig = num / 10;
    int seconddig = num % 10;
    int maxDigit = firstdig > seconddig ? firstdig : seconddig;
    return maxDigit;
}