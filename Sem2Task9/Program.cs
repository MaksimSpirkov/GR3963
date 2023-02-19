//Программа, которая выводит случайное
//число из отрезка [10, 99] и показывает наибольшую
//цифру числа. 

System.Random numSintezator = new System.Random();

//Вариант 1

// int rndNumber = numSintezator.Next(10, 100);

// Console.WriteLine(rndNumber);
// int firstNum = rndNumber/10;
// int secondNum = rndNumber%10;

// if (firstNum>secondNum)
// {
//    Console.WriteLine("Первое число больше второго: " + firstNum);
// }
// else
// {
//    Console.WriteLine("Второе число больше первого: " + secondNum);
// }

//Вариант 2

char[] digital = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digital);
int firstNumber = ((int)digital[0] - 48);
int secondNumber = ((int)digital[1] - 48);

int resultNumber = (firstNumber > secondNumber) ? resultNumber = firstNumber : resultNumber = secondNumber;
Console.WriteLine(resultNumber);