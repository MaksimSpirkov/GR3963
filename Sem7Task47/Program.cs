// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.Clear();

// Задаем размеры массива
Console.Write("Введите количество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());

// Создаем двумерный массив
double[,] array = new double[linesVol, columnsVol];

// Заполняем массив случайными вещественными числами
Random random = new Random(); // создаем генератор случайных чисел
for (int i = 0; i < linesVol; i++)
{
    for (int j = 0; j < columnsVol; j++)
    {
        array[i, j] = Convert.ToDouble(new Random().Next(-10, 10)); // заполняем ячейку случайным вещественным числом
    }
}

// Выводим массив на экран
for (int i = 0; i < linesVol; i++)
{
    for (int j = 0; j < columnsVol; j++)
    {
        Console.Write(array[i, j] + "\t"); // выводим значение ячейки на экран
    }
    Console.WriteLine(); // переходим на новую строку
}