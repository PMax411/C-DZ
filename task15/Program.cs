// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool GetWeekday(int number)
{
    if (number > 5)
    {
        return true;
    }
    return false;
}

int number = Prompt("Введите день недели => ");
if (GetWeekday(number))
{
    Console.WriteLine($"день {number} является выходным");
}
else
{
    Console.WriteLine($"день {number} не является выходным");
}
