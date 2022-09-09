// Рекурсия - ф-ция, вызывающая саму себя
// пример рекурсивной функции факториал

/*int Factorial (int n)
{
    //базовый случай - случай выхода из рекурсии
    if (n == 1) return 1;
    // рекурсивный случай - задание самой рекурсии (вызова функции)
    return n * Factorial (n-1);
}

Console.WriteLine(Factorial(5));
*/

//-----------------------------------------------------------------------------

/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

/*int N = Convert.ToInt32(Console.ReadLine());
// start = 1, откуда начинаем печать чисел, end = N, конец нашей последовательности
string PrintNumbers (int start, int end)
{
    // базовый случай
    if (start == end) return start.ToString(); // N = 5; start == 5, "5"
    return (start + ", " + PrintNumbers (start + 1, end));
}
Console.WriteLine($"Числа от 1 до {N}: {PrintNumbers(1, N)}");
*/

//------------------------------------------------------------------------------
/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/
/*int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
// start = M, откуда начинаем печать чисел, end = N, конец нашей последовательности
string PrintNumbers (int start, int end)
{
    // базовый случай
    if (start == end) return start.ToString(); // N = 5; start == 5, "5"
    // рекурсивный случай
    return (start + ", " + PrintNumbers (start + 1, end));
}
Console.WriteLine($"Числа от {M} до {N}: {PrintNumbers(M, N)}");
*/


//-----------------------------------------------------------------------

/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
/*int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers (int num)
{
    // базовый случай
    if (num == 0) return 0; // sum + 0 = sum
    // рекурсивный случай
    return (num % 10 + SumNumbers(num/10));
}
Console.WriteLine($"Сумма цифр в числе {number} = {SumNumbers(number)}");

*/
//----------------------------------------------------------------------

/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
/*int number = Convert.ToInt32(Console.ReadLine());
int degree = Convert.ToInt32(Console.ReadLine());

int Power (int number, int power)
{
    //базовый случай
    if (power == 0) return 1;
    if (power == 1) return number;
    return (number * Power (number, power - 1));
}
Console.WriteLine($"Число {number} возведенное в степень {degree} = {Power(number, degree)}");
*/


//----------------------------------------------------------------------

// Домашнее задание к семинару 9


//----------------------------------------------------------------------
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers (int start, int end)
{
    if (start == end) return end;
    return (start + SumNumbers (start + 1, end));
}
Console.WriteLine($"Сумма элементов в промежутке от {M} до {N} = {SumNumbers(M, N)}");
*/

//-------------------------------------------------------------------

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 9
*/
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Ackermann (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ackermann (m-1, 1);
    if (m > 0 && n > 0) return Ackermann (m-1, Ackermann (m, n-1));
    return Ackermann (m, n);
}

Console.WriteLine($"функция Аккермана A({M},{N}) = {Ackermann(M, N)}");

