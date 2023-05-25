// Task1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue);
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

// int EvenCount(int[] num)
// {
//     int count = 0;

//     for (int i = 0; i < num.Length; i++)
//     {
//         if (num[i] % 2 == 0) count++;
//     }
//     return count;
// }

// Console.Write("Input size: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int minValue = 100;
// int maxValue = 1000;

// int[] myArray = CreateRandomArray(num, minValue, maxValue);

// PrintArray(myArray);
// Console.Write($" -> {EvenCount(myArray)}");



// Task2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int Sum(int[] num)
// {
//     int sum = 0;

//     for (int i = 0; i < num.Length; i++)
//     {
//         if (num[i] % 2 != 0) sum += num[i];
//     }
//     return sum;
// }

// Console.Write("Input size: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int minValue = -2147483648;
// int maxValue = 2147483647;

// int[] myArray = CreateRandomArray(num, minValue, maxValue);

// PrintArray(myArray);
// Console.Write($" -> {Sum(myArray)}");



// Task3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// double[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     double[] newArray = new double[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue);
//     }
//     return newArray;
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// double MinNum(double[] array)
// {
//     double minNumber = array[0];

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (minNumber > array[i]) minNumber = array[i];
//     }
//     return minNumber;
// }

// double MaxNum(double[] array)
// {
//     double maxNumber = array[0];

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (maxNumber < array[i]) maxNumber = array[i];
//     }
//     return maxNumber;
// }

// Console.Write("Input size: ");
// int num =Convert.ToInt32(Console.ReadLine());

// int minValue = 1;
// int maxValue = 10;

// double[] myArray = CreateRandomArray(num, minValue, maxValue);

// double minNumber = MinNum(myArray);
// double maxNumber = MaxNum(myArray);

// PrintArray(myArray);
// Console.Write($" -> {maxNumber - minNumber}");