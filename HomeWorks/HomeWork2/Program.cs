// Task1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int InputNumber (string inputN)
{
    Console.Write(inputN);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// int treeDigitNumber = InputNumber("Input Tree Digit Number ");

// if (treeDigitNumber < 100 || treeDigitNumber >= 1000) 
// {
//     Console.WriteLine("The entered number is not a three-digit number"); 
//     return;
// }

// int result = treeDigitNumber / 10 % 10;

// Console.WriteLine($"The second digit of this three-digit number is: {result}");

// Task2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// bool TwoDigitNumber (int twoDigitNumber)
// {
//     if (twoDigitNumber < 100)
//     {
//         Console.WriteLine("No third digit");
//         return false;
//     }
//     else return true;
// }

// int TreeNumber (int number)
// {
//     while (number > 999)
//     {
//         int temp = number / 10; 
//         number = temp;
//     }
//     return number % 10;
// }

// int num = InputNumber("Input number ");

// if (TwoDigitNumber(num))
// {
//     Console.WriteLine($"Third digit of the number {num} -> {TreeNumber(num)}");
// }

// Task3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool ThisWeekDay (int day)
// {
//     if (day > 0 && day < 7) return true;
//     else Console.WriteLine("it's not a day of the week"); return false;
// }

// bool Weekend (int weekend)
// {
//     if (weekend > 5) return true;
//     else return false;
// }

// int weekendDay = InputNumber("Input week day ");

// if (ThisWeekDay(weekendDay))
// {
//     if (Weekend(weekendDay)) Console.WriteLine("Hooray!!! today is a day off");
//     else Console.WriteLine("Eh. gotta go to work");
// }
