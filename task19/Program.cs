// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Polindrome(number);
Console.WriteLine(result ? "является" : "не является");

bool Polindrome(int num)
{
    if (num < 10)
        return false;
    int tempNumber = num;
    int reveseNum = 0;

    while (num > 0)
    {
        reveseNum = reveseNum * 10 + num % 10;
        num = num / 10;
    }
    return tempNumber == reveseNum;
}
