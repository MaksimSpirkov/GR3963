// Программа, которая задаёт массив из N элементов и выводит 
// их на экран.


int[] array = new int[10];
Random myRandom = new Random();

Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 10);
    Console.Write("{0} ", array[i]);
}