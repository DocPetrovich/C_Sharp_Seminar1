// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 9999 || N > 99999)
{
    while (N < 9999 || N >= 99999)
    {
        Console.WriteLine("Ошибка! Введите пятизначное число:");
        N = Convert.ToInt32(Console.ReadLine());
    }
}

else
{
    int res5 = Convert.ToInt32(N % 10);
    int res1 = Convert.ToInt32(N / 10000);

    int res4 = Convert.ToInt32(N % 100 / 10);
    int res2 = Convert.ToInt32(N / 1000 % 10);
    // Console.WriteLine($"{res5}, {res1}, {res4}, {res2}");
    if (res1 == res5 && res2 == res4)
    {
        Console.WriteLine($"Число {N} является полиндромом");
    }
    else Console.WriteLine($"Число {N} не является полиндромом");
}