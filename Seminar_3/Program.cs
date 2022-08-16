// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в //которой находится эта точка.
/*Console.Write("Введите координату по оси ОХ: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси ОY: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("I четверть");
else if (x < 0 && y > 0) Console.WriteLine("II четверть");
else if (x < 0 && y < 0) Console.WriteLine("III четверть");
else if (x > 0 && y < 0) Console.WriteLine("IV четверть");
else Console.WriteLine("Ошибка такой четверти нет");
*/

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*Console.Write("Введите номер четверти: ");
int NumberOfQuarter = Convert.ToInt32(Console.ReadLine());

if (NumberOfQuarter == 1) Console.WriteLine("x > 0 и y > 0");
else if (NumberOfQuarter == 2) Console.WriteLine("x < 0 и y > 0");
else if (NumberOfQuarter == 3) Console.WriteLine("x < 0 и y < 0");
else if (NumberOfQuarter == 4) Console.WriteLine("x > 0 и y < 0");
else Console.WriteLine("Ошибка такой четверти нет");
*/


/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
/*Console.Write("Введите координату по оси ОХ точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси ОY точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси ОХ точки В: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси ОY точки В: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double resalt = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));

Console.WriteLine($"Расстояние между точками А и В равно {Math.Round(resalt,2)}");
*/

/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
/*Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

/*Console.WriteLine("Таблица квадратов чисел от 1 до заданного");
int start = 1;
double PowN = 0;
while (start <= Number)
{
    PowN = Math.Pow(start,2);
    start++;
    Console.WriteLine(PowN);
}
*/

//Второй вариант решения задачи с использованием цикла for
// int i = 0 - точка старта, откуда идем; какое-то условие; инкремент (i++)

/*for (int start = 1; start < Number; start++)
{
    Console.Write((Math.Pow(start,2)) + " "); // 
}
*/




// Домашнее задание к Семинару 3

/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите пятизначное число: ");
string? start = Console.ReadLine();
string result = " ";

for (int i = start.Length - 1; i >= 0; i--)
{
    result += start[i];
}
Console.WriteLine($"Перепишем заданное число в обратном порядке:{result}"); 

if (start == result) Console.WriteLine("Заданное число является палиндромом");
else Console.WriteLine("Заданное число не является палиндромом");


/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*Console.Write("Введите координату по оси ОХ точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси ОY точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси ОZ точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите координату по оси ОХ точки В: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси ОY точки В: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси ОZ точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));

Console.WriteLine($"Расстояние между точками А и В равно {Math.Round(d,2)}");
*/

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

for (int start = 1; start <= Number; start++)
{
    Console.Write((Math.Pow(start,3)) + " "); 
}
*/


