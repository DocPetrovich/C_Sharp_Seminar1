﻿// Задача №5.
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все уелые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = -number; i <= number; i++)
{
    Console.Write(i + " ");
}