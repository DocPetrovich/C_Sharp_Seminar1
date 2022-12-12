// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (numberA >= numberB && numberA >= numberC) max = numberA;
if (numberB >= numberA && numberB >= numberC) max = numberB;
if (numberC >= numberA && numberC >= numberB) max = numberC;

Console.WriteLine($"Максимальное число - {max}");