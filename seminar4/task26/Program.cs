// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// while (number > 0)
// {
//     number /= 10;
//     sum++;
// }

// Console.WriteLine(sum);

bool Validate(int number)
{
    if (number > 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int Sum1toA(int A)
{
    int i = 0;
    for (; A > 0; i++)
    {
        A /= 10;
    }
    return i;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetNumber("Введите число: ");
bool isCorrect = Validate(number);
if (isCorrect == true)
{
    int summa = Sum1toA(number);
    Console.WriteLine($"Количество цифр = {summa}");
}
else
{
    Console.WriteLine($"Невозможно посчитать количество цифр {number}");
}