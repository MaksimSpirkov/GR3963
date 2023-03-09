// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

Console.Clear();

int[,] arr = new int[10, 10]; // создаем двумерный массив

Random rnd = new Random(); // создаем экземпляр класса Random

// заполняем массив случайными числами от 0 до 10
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(10); // генерируем случайное число от 0 до 9
    }
}

// выводим массив на экран
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine()); // считываем номер строки
Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine()); // считываем номер столбца

if (row >= arr.GetLength(0) || col >= arr.GetLength(1)) // проверяем, что введенные номера не выходят за границы массива
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента: {arr[row, col]}"); // выводим значение элемента
}