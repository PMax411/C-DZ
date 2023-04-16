// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNumberBetweenAB(int numberA, int numberB)
{
    if (numberA == numberB) return numberB;
    else return numberA + SumNumberBetweenAB(numberA + 1, numberB);
}
bool Negative(int numberA, int numberB)
{
    return (numberA < 0 || numberB < 0);
}


Console.WriteLine("Введите целое положительное число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число");
int numB = Convert.ToInt32(Console.ReadLine());

int sumNumb = 0;
if(Negative(numA, numB)) 
{
    Console.WriteLine("Введены не натуральные числа");
    return;
}

if (numA <= numB)
    sumNumb = SumNumberBetweenAB(numA, numB);

if (numA > numB)
    sumNumb = SumNumberBetweenAB(numB,numA);

Console.WriteLine($"Сумма натуральных чисел от {numA} до {numB} равна {sumNumb}");