// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.WriteLine("Введите первое число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());
int res = A;

for (int i = 1; i < B; i++)
{
    res = res * A;
}
Console.WriteLine($"{A} в степени {B} = {res}");

// bool Validate(int A)
// {
//     if (A > 1)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// bool Validate(int B)
// {
//     if (B > 1)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// int PowAtoB(int C)
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// int GetNumber(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int number = GetNumber("Введите число: ");
// bool isCorrect = Validate(number);
// if (isCorrect == true)
// {
//     int summa = Sum1toA(number);
//     Console.WriteLine($"Сумма чисел от 1 до {number} = {summa}");
// }
// else
// {
//     Console.WriteLine($"Невозможно получить сумму от 1 до {number}");
// }