// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB) Console.WriteLine("Числа равны.");
else
{
    if (numberA > numberB) Console.WriteLine("Первое число больше второго.");
    else Console.WriteLine("Второе число больше первого");
}