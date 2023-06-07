// Task1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void ShowNumber(int n)
// {
//     if (n >= 1) 
//     {
//         Console.Write(n +" ");
//         ShowNumber(n - 1);
//     } 
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write($"{number} -> ");
// ShowNumber(number);



// Task2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int Sum(int m, int n)
// {
//     int sum = m;
//     if (m < n)
//     {
//         m++; 
//         sum = m + Sum(m, n);
//         return sum;  
//     }
//     else return 0;
// }

// Console.Write("Input number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"M = {m}; N = {n} -> {Sum(m - 1, n)}");



// Task3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ackermann(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Ackermann(m - 1, 1);
//     else return (Ackermann(m - 1, Ackermann(m, n - 1)));
// }

// Console.Write("Input number m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write($"A({m},{n}) = {Ackermann(m, n)}");