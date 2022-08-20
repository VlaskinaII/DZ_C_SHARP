using System;
/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

// 1. Через цикл for
// диапозон для суммы sum [1;A]
//Console.Write("Введите число А: ");
//int A = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
/*
for (int i = 0; i <= A; i++)
{
    sum+=i;
}
Console.WriteLine($"Сумма чисел от 1 до {A} равна {sum}");
*/

//2. Через метод и цикл while
/*int GetSumNumbers(int number)
{
    int sum = 0;
    int start = 0;
    while (start <= number)
    {
        sum += start;
        start++;
    }
    return sum;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSumNumbers(A)}");
*/


/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*Console.Write("Введите число: ");
string? number = Console.ReadLine();
int count = 0;
int size = number.Length;

for (int i = 0; i <= size-1; i++)
{
    count++;
}

Console.WriteLine($"Количество цифр в заданном числе равно {count}");
*/

/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
/*Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int factorialN = 1;

for (int i = 2; i <= N; i++)
{
    factorialN*=i;
}
Console.WriteLine($"Произведение чисел от 1 до {N} равно {factorialN}");
*/
//Другой вариант решения
/*Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int GetMultiply(int num)
{
    //[1;N]
    int result = 1; // умножение на 0 даст 0
    for (int i = 2; i <= num; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine($"Произведение чисел от 1 до {N} = {GetMultiply(N)}");
*/


/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
/*int [] Array = new int[8];
for (int i = 0; i < 8; i++)
{
    Array [i] = new Random().Next(2);
    Console.Write($"{Array[i]} ");
}
*/
//использование метода
/*int[] GetBinaryArray(int size)
{
    int [] result = new int[size]; // size = 5; result = [0,0,0,0,0]
    for (int i = 0; i < size; i++) // size = result.length
    {
        result[i] = new Random().Next(0,2); // Если указано одно число, то вы идете от 0 до этого числа
    }
    return result;
}

int [] testArray = GetBinaryArray(8);
Console.WriteLine($"Результат: [ {String.Join("; ", testArray)} ]");
*/







// Домашнее задание к семинару 4
/*
Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A == 0) Console.WriteLine("0 возведенный в любую степень = 0");
else
    {
        int result = 1;
        for (int i = 1; i <= B; i++)
            {
                result = result * A;
            }
    
        Console.WriteLine($"Число {A} возведенное в {B} степень = {result}");
    }
*/


/*
Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*Console.Write("Введите число: ");
string? number = Console.ReadLine();
int sum = 0;

for (int i = 0; i <= number.Length-1; i++)
{  
    sum+=Convert.ToInt32(number[i].ToString());
}
Console.Write($"Сумма цифр в числе равна {sum}");
*/
/*
Console.Write("Введите число: ");
string? input = Console.ReadLine();
int sum = 0;

for (int i = input.Length; i > 0; i--)
{
    string temp = input.Remove(i);
    sum += Convert.ToInt32(temp) % 10;
}
Console.Write($"Сумма цифр в числе равна {sum}");
*/

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(number > 0) 
{
    int result = number %10;
    sum += result;
    number /= 10;
}
Console.Write($"Сумма цифр в числе равна {sum}");
*/

/*
Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/
Console.Write("Введите длину массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] GetBinaryArray(int size)
{
    int [] result = new int[size]; 
    for (int i = 0; i < size; i++) 
    {
        result[i] = new Random().Next(0,100); 
    }
    return result;
}

Console.WriteLine($"Результат: [{String.Join(", ", GetBinaryArray(lengthArray))}]");

