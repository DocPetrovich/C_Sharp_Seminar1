﻿// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int mod = number % 2;

if (mod > 0) Console.WriteLine("Число нечетное.");
else Console.WriteLine("Число четное.");