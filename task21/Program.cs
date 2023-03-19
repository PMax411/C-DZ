// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите первую кординату x: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую кординату y: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую кординату z: ");
int numZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую кординату x: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую кординату y: ");
int numY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую кординату z: ");
int numZ2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(numX1, numY1, numZ1, numX2, numY2, numZ2);

double resRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Растояние равно {resRound}");
double Distance(int numX1, int numY1, int numZ1, int numX2, int numY2, int numZ2)
{
    int X = numX1 - numX2;
    int Y = numY1 - numY2;
    int Z = numZ1 - numZ2;
    double c = Math.Sqrt(X * X + Y * Y + Z * Z);
    return c;
}
