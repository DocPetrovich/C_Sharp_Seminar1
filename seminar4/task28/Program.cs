// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите целое число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int res = 1;
// int n = 1;

// while (number >= n)
// {
//     res = n * res;
//     n++;    
// }

// Console.WriteLine(res);

bool Validate(int number)
{
    if (number >= 1)
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
    int sum = 1;
    for (int i = 1; i <= A; i++)
    {
        sum *= i;
    }
    return sum;
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
    Console.WriteLine($"Произведение чисел от 1 до {number} = {summa}");
}
else
{
    Console.WriteLine($"Невозможно получить произведение от 1 до {number}");
}