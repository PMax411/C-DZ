// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите первую кординату x: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую кординату y: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую кординату x: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую кординату y: ");
int numY2 = Convert.ToInt32(Console.ReadLine());
double result = Distance(numX1,numY1,numX2,numY2);
 
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Растояние равно {resRound}");
double  Distance (int numX1 ,int numY1 ,int numX2 ,int numY2){
    int X=numX1-numX2;
    int Y= numY1 - numY2;
    double c = Math.Sqrt(X*X + Y*Y);
    return c;
}
