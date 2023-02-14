// Название дня недели по заданному числу

Console.Write("Введите номер дня недели: ");
string? LineDay = Console.ReadLine();
if (LineDay != null)
{
    int day = int.Parse(LineDay);
    string[] dayweek = new string[7];
    dayweek[0] = "Понедельник";
    dayweek[1] = "Вторник";
    dayweek[2] = "Среда";
    dayweek[3] = "Четверг";
    dayweek[4] = "Пятница";
    dayweek[5] = "Суббота";
    dayweek[6] = "Воскресенье";
    Console.Write(dayweek[day - 1]);
}