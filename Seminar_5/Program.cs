
/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/
/*int [] array = new int [12]; // array = [0,0,...,0]

int resultPositive = 0; //сумма положительных чисел
int resultNegative = 0; //сумма отрицательных чисел

int i = 0;

int arraySize = array.Length; // Длина массива - кол-во элементов

while (i < arraySize)
{
    array[i] = new Random().Next(-9,10); // [-9,9]
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

for (int j = 0; j < arraySize; j++)
{
   // число отрицательное 
   if (array[j] < 0) resultNegative += array[j]; 
   else resultPositive += array[j];
 
}

Console.WriteLine($"Сумма положительных чисел = {resultPositive} и сумма отрицательных чисел = {resultNegative}");
// в дальнейшем лучше использовать один цикл for
*/

/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
/*int [] array = new int [4]; 
int arraySize = array.Length;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(-9,10);
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

for (int j = 0; j < arraySize; j++)
{
    array[j] *= (-1);
}
Console.WriteLine($"Array с заменой положит чисел на отрицательные: [ {String.Join("; ", array)} ]");
*/


/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
/*int [] array = new int [4]; 
int arraySize = array.Length;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(-100,101);
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool flagResult = false;
for (int j = 0; j < arraySize; j++)
{ 
    if (array[j] == number) 
    {
        flagResult = true;
        break;
    }
}
if (flagResult) Console.Write("Заданное число присутствует в массиве");
else Console.Write("Заданное число отсутствует в массиве");
*/


/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/*int [] array = new int [123]; 
int arraySize = array.Length;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(0,200);
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

int count = 0;
for (int j = 0; j < arraySize; j++)
{
    if (array[j] >= 10 && array[j] <= 99) count++;
}
Console.Write($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно {count}");
*/

/*
Домашнее задание к семинару 5

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size]; 
int arraySize = array.Length;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(0,1000);
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

int count = 0;
for (int j = 0; j < arraySize; j++)
{
    if (array[j] %2 ==0) count++;
}
Console.Write($"Количество четных чисел в массиве равно {count}");
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size]; 
int arraySize = array.Length;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(-99,100);
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

int sum = 0;

for (int j = 0; j < arraySize; j++)
{
    if (j %2 != 0) sum += array[j];
}
Console.Write($"Сумма элементов, стоящих на нечётных позициях = {sum}");
*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double [size]; 
int arraySize = array.Length;

for (int i = 0; i < arraySize; i++)
{
    double start = new Random().NextDouble()*100;
    start = Math.Round(start,1);
    array[i] = start;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

Array.Sort(array);
//Console.WriteLine($"Arraysort: [ {String.Join("; ", array)} ]");

double result = Math.Round((array [arraySize-1] - array[0]),2);
Console.WriteLine($"Разница между макс и мин элементами массива = {result}");
