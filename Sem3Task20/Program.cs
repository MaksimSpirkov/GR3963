// Программа, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

int ReadData(string msg) // Метод читает данные от пользователя
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, double val) // Метод выводит данные пользователя
{
    Console.WriteLine(msg + val);
}

double CalcLen2D(int x1, int x2, int y1, int y2) // Метод находит растояние между точками на плоскости
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}

int x1 = ReadData("Введите координату X точки A: ");
int y1 = ReadData("Введите координату Y точки A: ");
int x2 = ReadData("Введите координату X точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");

double res = CalcLen2D(x1, x2, y1, y2);

PrintData("Растояние между точками А и В: ", res);