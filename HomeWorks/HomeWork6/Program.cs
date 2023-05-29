// Task1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int InputNumber (string inputN)
// {
//     Console.Write(inputN);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] InputArray (int length)
// {
//     int[] array = new int[length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = InputNumber($"Input {i + 1} element: ");
//     }
//     return array;
// }

// int Counter(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// } 

// int length = InputNumber("Input length of array: ");

// int[] array = InputArray(length);

// PrintArray(array);
// Console.WriteLine($"the number of numbers greater than zero -> {Counter(array)}");




// Task2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double b1 = InputNumber("Input b1: ");
// double k1 = InputNumber("Input k1: ");
// double b2 = InputNumber("Input b2: ");
// double k2 = InputNumber("Input k2: ");

// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Point of intersection of two lines: ({x},{y})");