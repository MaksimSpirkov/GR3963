// Программа, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.


{
    Console.Write("Введите пятизначное число: ");
    string? number = Console.ReadLine();
    string rev = string.Concat(number.Reverse());
    Console.WriteLine(number == rev ? "Палиндром" : "Не палиндром");
}
