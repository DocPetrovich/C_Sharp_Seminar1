// Задача 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int digit3 = number % 10;
int digit1 = number / 100;
Console.WriteLine($"Первая цифра = {digit1}, Третья цифра = {digit3}");

Console.WriteLine($"Искомое число = {digit1 * 10 + digit3}");