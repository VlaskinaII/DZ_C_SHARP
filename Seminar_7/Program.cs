/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] ResultMatrix = GetArray(rows, columns);
PrintArray(ResultMatrix);

//m - строки, n - столбцы
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}

void PrintArray(int[,] imputMatrix)
{
    for (int i = 0; i < imputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < imputMatrix.GetLength(1); m++)
        {
            Console.Write(imputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
*/

/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

/*Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] ResultMatrix = GetArray(rows, columns);
PrintArray(ResultMatrix);

//m - строки, n - столбцы
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
        }
    }
    return matrix;
}

void PrintArray(int[,] imputMatrix)
{
    for (int i = 0; i < imputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < imputMatrix.GetLength(1); m++)
        {
            Console.Write(imputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
*/

/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на 
их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4

*/

/*Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] ResultMatrix = GetArray(rows, columns);
PrintArray(ResultMatrix);

//m - строки, n - столбцы
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}

void PrintArray(int[,] imputMatrix)
{
    for (int i = 0; i < imputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < imputMatrix.GetLength(1); m++)
        {
            Console.Write(imputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] RepLaceBySquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i%2 == 0 && j%2 == 0) matrix[i,j] = Convert.ToInt32(Math.Pow(matrix[i,j],2));
        }
    }
    return matrix;
}
RepLaceBySquare(ResultMatrix);
Console.WriteLine();
PrintArray(ResultMatrix);
*/

/*Задача 51. Найти сумму элементов главной диагонали.
апример, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
/*Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] ResultMatrix = GetArray(rows, columns);
PrintArray(ResultMatrix);

//m - строки, n - столбцы
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}

void PrintArray(int[,] imputMatrix)
{
    for (int i = 0; i < imputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < imputMatrix.GetLength(1); m++)
        {
            Console.Write(imputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
int sum = 0;
for (int i = 0; i < ResultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
            if (i == j) sum += ResultMatrix[i,j];
        }
    }
Console.Write("Сумма элементов главной диагонали = " + sum);
*/




// Домашнее задание к Семинару 7
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
/*Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] ResultMatrix = GetArray(rows, columns);
PrintArray(ResultMatrix);

double [,] GetArray(int m, int n)
{
    double[,] matrix = new double[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round((new Random().NextDouble()*10),1);
        
        }
    }
    return matrix;
}

void PrintArray(double [,] imputMatrix)
{
    for (int i = 0; i < imputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < imputMatrix.GetLength(1); m++)
        {
            Console.Write(imputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
*/


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
/*Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] ResultMatrix = GetArray(rows, columns);
PrintArray(ResultMatrix);

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}

void PrintArray(int[,] imputMatrix)
{
    for (int i = 0; i < imputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < imputMatrix.GetLength(1); m++)
        {
            Console.Write(imputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите номер строки искомого элемента массива: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента массива: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

if (rows1 > rows && columns1 > columns) Console.WriteLine($"Элемента на позиции ({rows1},{columns1}) в матрице нет");
else 
{
    int element = ResultMatrix[rows1,columns1];
    Console.Write($"Элемент стоящий на позиции [{rows1},{columns1}] = {element}");
}
*/ 


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] ResultMatrix = GetArray(rows, columns);
PrintArray(ResultMatrix);

//m - строки, n - столбцы
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}

void PrintArray(int[,] imputMatrix)
{
    for (int i = 0; i < imputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < imputMatrix.GetLength(1); m++)
        {
            Console.Write(imputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
double sum = 0;
double average = 0;
int j = 0; 

while (j < ResultMatrix.GetLength(1))
    {
        for (int i = 0; i < ResultMatrix.GetLength(0); i++)
        {
            sum += ResultMatrix[i,j];
           
        }
        average = Math.Round((sum / rows),1);
        Console.WriteLine($"Среднее арифметическое элементов в {j+1} столбце = {average}");
        j++;
    }




