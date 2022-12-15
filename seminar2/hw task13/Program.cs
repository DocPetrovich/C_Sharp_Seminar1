// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int res = number;

// if (number < 100) Console.WriteLine("Третьей цифры нет.");

// if (res > 99 && res < 1000) res = res % 10;

// else
// {
//     while (res > 999)
//         res = res / 10;
// }

// Console.WriteLine($"Третья цифра - {res % 10}");


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = number;

if (number < 100) Console.WriteLine("Третьей цифры нет.");

while (res > 999) res /= 10;

Console.WriteLine($"Третья цифра - {res % 10}");