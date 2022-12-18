// Задача №22. Напишите программу, которая принимает на вход число N и выдает таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4.


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
        Console.WriteLine($"Квадрат числа {i} = {i * i}");
    }
}