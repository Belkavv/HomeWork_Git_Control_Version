// Task1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Degree(int numA, int numB)
// {
//     int num_n = 1;

//     for ( int i = 0; i < numB; i++)
//     {
//         num_n *= numA;
//     }
//     return num_n;
// }

// Console.Write("Input number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// int result = Degree(numA, numB);

// Console.WriteLine($"{numA} ^ {numB} = {result}");


// Task2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return sum;
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = Sum(num);

// Console.WriteLine($"The sum of the digits in a number {num} -> {result}");

// Task3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size, minValue, maxValue);

// PrintArray(myArray); 
