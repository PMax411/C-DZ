// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите число №1 ");
 int firstNumber = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите число №2 ");
 int secondNumber = Convert.ToInt32(Console.ReadLine());
 bool result = squre(firstNumber,secondNumber);
 Console.WriteLine(result  ? "Явлеется" : $"не является" );


 bool squre (int secondNum, int firstNum) {
    
        return   secondNum == firstNum * firstNum || firstNum == secondNum*secondNum   ;

    
 }
