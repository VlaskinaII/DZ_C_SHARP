/*
Напишите программу, которая на входе принимает число и выводит его квадрат
Например:
4 -> 16
-3 -> 9
*/
//int number = Convert.ToInt32(Console.ReadLine());

//int square = number * number; // 5*5=25

// int result = Convert.ToInt32(Math.Pow(number,2)); // без конверт возвращ doble

//Console.WriteLine("квадрат от числа " + number + " = " + square);
// склеить строчки - конвертация

//1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго
// а = 25, b = 5 -> да
// a = 2, и = 10 -> нет

//Console.Write("Ввкдите первое число: ");
//int firstNumber = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите второе число: ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());

// "==" - проверка на равенство: 5 == 5 - True
// "!=" - проверка на не равенство
//if (firstNumber == secondNumber * secondNumber)
//{
 //  Console.WriteLine(firstNumber + " является квадратом от " + secondNumber); 
//}
//else Console.WriteLine(firstNumber + " не является квадратом от " + secondNumber)

/*int number = Convert.ToInt32(Console.ReadLine()); // n - number
int negativeNumber = number*(-1);                 // -n = n * (-1)

while (negativeNumber <= number)
{
    Console.Write(negativeNumber + " ");
    negativeNumber++;
}
*/

//Домашнее задание к первому семинару
/*
Задача №2
Напишите программу, которая на вход принимает два числа и выдает какое число больше,
а какое меньше.
а = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3
*/
/*Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " больше " + secondNumber); 
}
else Console.WriteLine(secondNumber + " больше " + firstNumber); 
*/


/*
Задача №6
Напишите программу, которая на воход принимает число и выдает, является ли число четным
4 -> да
-3 -> нет
7 -> да
*/
/*Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number %2 == 0) // проверка на четность
{
    Console.WriteLine("число " + Number + " является четным");
}
else Console.WriteLine("число " + Number + " является не четным");
*/

/*
Задача №8
Напишите программу, которая на воход принимает число (N), 
а на выходе показывает все четные числа от 1 до N
4 -> 2,4
8 -> 2,4,6,8
*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // N - number

for (var i = 1; i < number; i++)
{
    if (i %2 == 0)
    {
      Console.Write(i + " ");  
    }
}