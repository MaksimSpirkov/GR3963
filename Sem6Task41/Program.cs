// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите элементы через пробел: ");
int[] myArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество элементов больше 0: {count}");