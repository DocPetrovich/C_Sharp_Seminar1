
// Задача №7.
// Напишите программу, которая принимает на вход трехначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
int mod = number % 10;
Console.WriteLine($"Последняя цифра трехзначного числа - {mod}");
}
else
{
Console.WriteLine("Введено не трехзначное число");
}