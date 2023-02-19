// Программа, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.


Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
var dayNum = new Dictionary <int, string> ()
{
[1] = "Понедельник",
[2] = "Вторник",
[3] = "Среда",
[4] = "Четверг",
[5] = "Пятница",
[6] = "Суббота",
[7] = "Воскресенье"
};
if(day>0 && day<8)
{
Console.Write(dayNum[day]);
}
if (day >= 1 && day <=7)
{
if (day >= 6)
{
Console.Write(" выходной день" );
}
else
{
Console.Write(" рабочий день" );
}
}
else
{
Console.Write("Данное число не являеться днём недели");
}