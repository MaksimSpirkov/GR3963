// Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbers);

int result = 0;

for (int i = 0; i < numbers.Length; i += 2)
{
    result = result + numbers[i];
}
Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {result}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}