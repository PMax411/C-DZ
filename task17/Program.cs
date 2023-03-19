// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите кординаты точки ");
Console.Write("X: ");

int xCordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCordinate = Convert.ToInt32(Console.ReadLine());

int result = Quater(xCordinate,yCordinate);
string res = result > 0 ? $"Указанные кординаты соответствуют => {result} четверти": "Неверно ввели кординаты";
Console.WriteLine(res);
int Quater(int x, int y){
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;
    if (x>0 && y<0) return 4;
    return 0;
}