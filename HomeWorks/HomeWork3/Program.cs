double InputNumber (string inputN)
{
    Console.Write(inputN);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

// Task1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void CheckPalindrom(int number)
// {
//     if (number > 9999 && number < 100000)
//     {
//         if (number / 10000 == number % 10)
//         {
//             number = number / 10;
//             if ((number / 100) % 10 == number % 10)
//             {
//                 Console.WriteLine("Yes");
//             }
//         }
//         else Console.WriteLine("No");
//     }
//     else Console.WriteLine("Invalid number");
// }

// int num = Convert.ToInt32(InputNumber("Input five-digit number: "));

// Console.Write($"{num} -> "); 
// CheckPalindrom(num);

// Task2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Distance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
// }

// double xa = InputNumber("Input coordinate X point A: ");
// double ya = InputNumber("Input coordinate Y point A: ");
// double za = InputNumber("Input coordinate Z point A: ");
// double xb = InputNumber("Input coordinate X point B: ");
// double yb = InputNumber("Input coordinate Y point B: ");
// double zb = InputNumber("Input coordinate Z point B: ");

// Console.WriteLine($"Distance between point A ({xa}, {ya}, {za}) and point B ({xb}, {yb}, {zb}) -> {Distance(xa, ya, za, xb, yb, zb)}");

// Task3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube (int num)
// {
//     int count = 1;

//     while (count <= num)
//     {
//         int result = count * count * count;
//         count++;
//         Console.Write(result + " ");    
//     }   
// }

// int number = Convert.ToInt32(InputNumber("Input number: "));

// if (number > 1)
// {
//         Console.Write($"{number} -> ");
//         Cube(number);
// }
// else Console.WriteLine("Invalid number");
