/*Домашняя работа

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Cоздание и заполнение элементами массива
// Matrix - прямоугольная табличка, которая состоит
// из m строк и n столбцов (табличка)
// m - cтрочки, n - столбцы, 0 - minRandom, 10 - maxRandom
int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, matrix.GetLength(0) = m
    {
        // i, m, k, j
        for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return matrix;
}

// Напечатать массив
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // Tab между элементами
        }
        Console.WriteLine();
    }
}

// Получаем матрицу из rows строк и columns столбцов,
// элементы от 0 до 10
int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix);

Console.WriteLine("Result matrix: ");

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < resultMatrix.GetLength(1) - 1; k++)
        {
            if (resultMatrix[i, k] < resultMatrix[i, k + 1])
            {
                int temp = resultMatrix[i, k + 1];
                resultMatrix[i, k + 1] = resultMatrix[i, k];
                resultMatrix[i, k] = temp;
            }
        }
        //Console.Write(resultMatrix[i, j] + "\t");
    }
    //Console.WriteLine();
}
PrintMatrix(resultMatrix);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Cоздание и заполнение элементами массива
// Matrix - прямоугольная табличка, которая состоит
// из m строк и n столбцов (табличка)
// m - cтрочки, n - столбцы, 0 - minRandom, 10 - maxRandom
int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, matrix.GetLength(0) = m
    {
        // i, m, k, j
        for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return matrix;
}

// Напечатать массив
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // Tab между элементами
        }
        Console.WriteLine();
    }
}

// Получаем матрицу из rows строк и columns столбцов,
// элементы от 0 до 10
int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix);

Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(resultMatrix)}");

int GetRowNumber (int [,] array)
    {
      int row = 0;
      int minsum = 0;
      for (int i = 0; i < array.GetLength(1); i++)
      {
        minsum = minsum + array[0,i];
      }

      for (int i = 1; i < array.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum = sum + array[i,j];
        }
        if (minsum > sum)
        {
          minsum = sum;
          row = i;
        }
      }
      return row;
    }
    */


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] FirstMatrix = new int[rows, columns];
int[,] SecondMatrix = new int[rows, columns];
int[,] FirstGetMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, matrix.GetLength(0) = m
    {
        // i, m, k, j
        for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return matrix;
}

int[,] SecondGetMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, matrix.GetLength(0) = m
    {
        // i, m, k, j
        for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return matrix;
}

// Напечатать массив
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // Tab между элементами
        }
        Console.WriteLine();
    }
}

// Получаем матрицу из rows строк и columns столбцов,
// элементы от 0 до 10

Console.WriteLine();
Console.WriteLine("Первая матрица");
int[,] resultMatrix1 = FirstGetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix1);

Console.WriteLine();
Console.WriteLine("Вторая матрица");
int[,] resultMatrix2 = SecondGetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix2);

Console.WriteLine($"\nПроизведение первой и второй матриц:");
//int m = 0; int n = 0;
int[,] resultMatrix = new int[rows, columns];
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < resultMatrix.GetLength(0); k++)
        {
            sum += resultMatrix1[i, k] * resultMatrix2[k, j];
        }
        resultMatrix[i, j] = sum;
        Console.Write(resultMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}
