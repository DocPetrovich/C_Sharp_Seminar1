﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 0)
{
    while (N < 1)
    {
        Console.WriteLine("Введите число больше нуля!");
        N = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"Квадрат числа {i} = {i * i}");
        }
    }

}
else
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"Куб числа {i} = {i * i * i}");
    }
}