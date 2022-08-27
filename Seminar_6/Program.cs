/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/
/*int size = 5;
int [] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(11);
}
Console.WriteLine($" Array: [ {String.Join("; ", array)} ]");

//1. Создать массив, в который мы скопируем текущий

int[] resultArray = new int[size];
int lastIndex = size - 1;
for (int i = 0; i < size; i++)
{
    resultArray[i] = array[lastIndex - i];
}
Console.WriteLine($" Reverse array: [{String.Join("; ", resultArray)}]");
*/

/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
//a
//b
//c
// a+b>c
// b+c>a
// a+c>b

/*Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && b + c > a && a + c > b) Console.WriteLine("Теорема выполняется");
else Console.WriteLine("Теорема не выполняется");
*/


/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
// 1й способ:
/*Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size]; 
array[0] = 0;
array[1] = 1;

for (int i = 2; i < size; i++)
{
    array[i] = array[i-2] + array[i-1];
}
Console.WriteLine($"Первые {size} чисел Фибоначчи = {String.Join(" ", array)}");
*/
// 2й способ через числа:

/*int N = 10;
int fistElement = 0;
int secondElement = 1;

Console.WriteLine(fistElement);
Console.WriteLine(secondElement);

for (int i = 3; i <= N; i++)
{
    int nextElement = fistElement + secondElement;
    Console.WriteLine(nextElement);
    fistElement = secondElement;
    secondElement = nextElement;

}
*/


/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/
/*Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size]; 
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(11);
}
Console.WriteLine($"Array: [{String.Join("; ", array)}]");

int[] copyArray = new int[size];
for (int j = 0; j < size; j++)
{
    copyArray[j] = array[j];
}
Console.WriteLine($"CopyArray: [{String.Join("; ", copyArray)}]");
*/
/*int[] CopyArray (int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}*/




/* Домашняя работа к семинару 6

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите с клавиатуры числа разделяя их запятой и пробелом: ");

string array = Console.ReadLine();
string[] resultArray = array.Split(",");

int count = 0;
int size = resultArray.Length;

for (int i = 0; i < size; i++)
{
    if(Convert.ToInt32(resultArray[i].Trim()) > 0 ) count++;
    
}
//Console.WriteLine($"Массив введенных пользователем чисел: [{String.Join(", ", resultArray)}]");

Console.WriteLine($"Количество чисел больше 0 в веденном пользователем массиве = {count}");


/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 != k2)
{
    double X = (b2 - b1) / (k1 - k2);
    double Y = k1 * X + b1;
    Console.WriteLine($"Прямые пересекаются в точке ({X},{Y})");
}

else Console.WriteLine("Прямые не пересекаются");
*/