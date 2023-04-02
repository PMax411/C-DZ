// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine($"Введите число A" );
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число B" );
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число C" );
int numberC = Convert.ToInt32(Console.ReadLine());
bool result = IsExist(numberA,numberB,numberC);

bool IsExist(int num1,int num2,int num3){
    if (num1<num2+num3&&num2<num1+num3&&num3<num1+num2) 
    {
        Console.WriteLine("Может существовать");
    }
    else{
       Console.WriteLine("Не Может существовать");
    }
    
    return true;

}

