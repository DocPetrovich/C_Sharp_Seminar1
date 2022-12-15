
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели от 1 до 7: ");
int weekNumber = Convert.ToInt32(Console.ReadLine());

if (weekNumber < 1 || weekNumber > 7) 
{
    while (weekNumber < 1 || weekNumber > 7)
    {
    Console.WriteLine("Ошибка! Цифра недели не может быть меньше 1 и больше 7.");
    Console.WriteLine("Введите цифру дня недели заново: ");
    weekNumber = Convert.ToInt32(Console.ReadLine());
    }
}
if (weekNumber > 0 && weekNumber < 6) Console.WriteLine("Этот день недели - не выходной.");
else Console.WriteLine("Этот день недели - выходной.");