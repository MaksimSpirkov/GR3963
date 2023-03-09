// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

// создаем трехмерный массив размерностью 2x2x2
int[,,] array = new int[2, 2, 2];

// заполняем массив неповторяющимися двузначными числами
int num = 10;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = num++;
        }
    }
}

// выводим массив на экран
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine("Слой {0}:", i);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.WriteLine("Элемент [{0}, {1}, {2}] = {3}", i, j, k, array[i, j, k]);
        }
    }
}