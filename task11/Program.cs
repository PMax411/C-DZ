// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Трехзначное число -- > {number}");

int numb = RemoveSecondGigital(number);
Console.WriteLine($"Число -> {numb}");


int RemoveSecondGigital(int num)
{
    int firstDigital = num / 100;
    int thirdDigital = num % 10;
    int result = firstDigital * 10 + thirdDigital;
    return result;


}