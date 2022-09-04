// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет
// местами первую и последнюю строку массива

/*int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

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

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

// метод замены строк
void ChengeRows(int [,] imputMatrix)
{
    int indexLastRow = imputMatrix.GetLength(0) - 1; // size - 1
    for (int j = 0; j < imputMatrix.GetLength(1); j++)
    {
        int temp = imputMatrix[0,j];
        imputMatrix[0,j] = imputMatrix[indexLastRow,j];
        imputMatrix[indexLastRow,j] = temp;
    }
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine();
ChengeRows(resultMatrix);
Console.WriteLine("Result: ");
PrintArray(resultMatrix);
*/

/*Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
*/

/*Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
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

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

int minElement = int.MaxValue;
int indexminRows = 0;
int indexminColumns = 0;

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        if (minElement > resultMatrix[i,j])
        {
            indexminColumns = j;
            indexminRows = i;
            minElement = resultMatrix[i,j];
        }
    }
    Console.WriteLine();
}

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    if (indexminRows != i)
    {    
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if (indexminColumns != j)
            {
                Console.Write(resultMatrix[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}

*/




/*Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
*/

/*int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

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

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        result[j,i] = matrix[i, j];
        }
    }
    return result;
}

if (rows == columns)
{
    int[,] resultMatrix = GetArray(rows, columns);
    PrintArray(resultMatrix);
    Console.WriteLine("Result: ");
    PrintArray(ChangeArray(resultMatrix));
}
else Console.WriteLine("Операцию замены возможно выполнить в массиве с одинаковым количеством строк и столбцов");
*/




//Домашнее задание к Семинару 8
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

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

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] Matrix = GetArray(rows, columns);
PrintArray(Matrix);

for (int i = 0; i < Matrix.GetLength(0); i++)
{
    SortMatrix(i, Matrix);
}

void SortMatrix(int row, int[,] matrix) {
    bool IsSorted = false;
    while(!IsSorted) {
        IsSorted = true;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if(matrix[row,j] < matrix[row, j+1]) {
            IsSorted = false;

            int temp = matrix[row,j];
            matrix[row,j] = matrix[row,j+1];
            matrix[row,j+1] = temp;
            }
        }
    }
}
Console.WriteLine("Result: ");
PrintArray(Matrix);

*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/



/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
//--------------- TASK ----------------
Console.Write("Введите количество строк первой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix;
int[,] secondMatrix;
int[,] resultMatrix;

if (rows != columns1) 
{
    Console.WriteLine("Количество строк первой матрицы д/б равно количеству столбцов второй матрицы");
    return;
}
else 
{
    firstMatrix = GetArray(rows, columns);
    secondMatrix = GetArray(rows1, columns1);
    resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    PrintArray(firstMatrix);
    Console.WriteLine();
    PrintArray(secondMatrix);
    Console.WriteLine("Result: ");
    MultiplyArray(firstMatrix, secondMatrix);
    PrintArray(resultMatrix);
}

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

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void MultiplyArray(int[,] matrix, int[,] matrix1)
{    
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sum += matrix[i, k] * matrix[k, j];
            }
            resultMatrix[i,j] = sum;
        }
    }
}
//---------------- END TASK ---------------------
*/


/*
//--------------- TASK ----------------
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
int[,,] GetArrayThird()
{
    int sizeMatrix = 2;
    int[,,] matrix = new int[sizeMatrix,sizeMatrix,sizeMatrix];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = new Random().Next(99);
            }
        }
    }
    return matrix;
}

void PrintArrayThird(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k})" + "\t");
            }
            Console.WriteLine();
        }
    }
}
//---------------- END TASK ---------------------
*/

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/