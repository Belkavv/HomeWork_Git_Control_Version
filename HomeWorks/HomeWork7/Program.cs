// Task1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7   -2  -0,2
//  1 -3,3   8  -9,9
//  8  7,8 -7,1   9


// double[,] Create2DRandomArray(int rows, int cols, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, cols];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write(array[i, j] + " ");
//        }
//        Console.WriteLine();
//     }
//     Console.WriteLine();
// }

Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = Create2DRandomArray(rows, cols, minValue, maxValue);

// Print2DArray(myArray);



// Task2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// bool Element(int row, int col, double[,] array)
// {
//     if (row < 0 | row > myArray.GetLength(0) - 1 || col < 0 || col > myArray.GetLength(1) - 1) return false;
//     else return true;
// }

// Console.Write("Enter row position: ");
// int row = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Enter col position: ");
// int col = Convert.ToInt32(Console.ReadLine()) - 1;

// Print2DArray(myArray);

// if (Element(row, col, myArray) == true) Console.WriteLine($"{row + 1} {col + 1} -> {myArray[row, col]}");
// else Console.WriteLine($"{row + 1} {col + 1} -> Такого элемента нет");



//Task3.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] Create2DRandomArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
           Console.Write(array[i, j] + " ");
       }
       Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}

double[] MeanCol(int[,] array)
{
        double[] meanArray = new double[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double sum = 0;
            double mean = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, j];
            }
            Math.Round(mean = sum / array.GetLength(0));
            meanArray[j] = mean;
        }
        return meanArray;
}

int[,] myArray = Create2DRandomArray(rows, cols, minValue, maxValue);

Print2DArray(myArray);
Console.Write($"Arithmetic mean of each column -> ");
PrintArray(MeanCol(myArray));