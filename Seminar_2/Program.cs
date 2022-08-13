// 78 -> 7 и 8, 8
// 12 -> 1 и 2, 2
// 85 -> 8 и 5

/*int number = new Random().Next(10,100);
Console.WriteLine("Рандомное число: " + number);

int firstDigit = number / 10; // Первая цифра моего числа 78 -> 7
int secondDigit = number % 10; // Вторая цифра моего числа 78 -> 8

int max = firstDigit; // пусть максимум первая цифра
if (max < secondDigit) max = secondDigit;

Console.WriteLine($"Максимальное цифра в числе {number} - это {max}"); //интерполяция
*/

/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
/*int number = new Random().Next(10,1000);
Console.WriteLine("Рандомное число: " + number);
int firstDigit = number / 100;
int thirdDigit = number % 10;

Console.WriteLine($"{firstDigit}{thirdDigit}"); 
*/

/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

//int firstDigit = new Random().Next(99);
//int secondDigit = new Random().Next(11);
/*Console.Write("Введите ервое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit % secondDigit == 0) Console.WriteLine("Первое число кратно второму");
else 
{
    int divdel = firstDigit % secondDigit; 
    Console.WriteLine($"Перове число не кратно второму, остаток от деления - {divdel}");
}
*/

/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23. 14 -> нет 46 -> нет 161 -> да
*/
/*Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number %7 == 0 && number %23 == 0) Console.WriteLine("Веденное число кратно 7 и 23");
else Console.WriteLine("Веденное число не кратно 7 и 23");
*/


// Домашнее задание к семинару 2
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*int number = new Random().Next(10,1000);
Console.WriteLine($"Случайное трехзначное число число: {number}");
int var = number % 100;
int resalt = var / 10;
Console.WriteLine($"Вторая цифра числа: {resalt}"); */

/*Console.Write("Введите трехзначное число: "); 
int number = Convert.ToInt32(Console.ReadLine());
int var = number % 100;
int resalt = var / 10;
Console.WriteLine($"Вторая цифра числа: {resalt}"); */


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.Write ("Третьей цифры в числе нет");
else 
{
    Console.WriteLine("Третья цифра в числе: " + number.ToString()[2]);
}

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*Console.Write("Введите число в диапозоне от 1 до 7: "); 
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7) Console.WriteLine("Ура! Это выодной день!");
else Console.WriteLine("Это рабочий день");*/