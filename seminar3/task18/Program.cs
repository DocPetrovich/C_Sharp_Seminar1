// Задача №18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).



Console.WriteLine("Введите номер четверти:");
int num = Convert.ToInt32(Console.ReadLine());


if (num < 1 || num > 4)
{
    Console.WriteLine("Ошибка! Неверно введен номер");
}
else if (num == 1)
{
    Console.WriteLine("Диапазон точек первой четверти - x > 0, y > 0");
}
else if (num == 2)
{
    Console.WriteLine("Диапазон точек второй четверти - x > 0, y > 0");
}
else if (num == 3)
{
    Console.WriteLine("Диапазон точек третьей четверти - x < 0, y < 0");
}
else if (num == 4)
{
    Console.WriteLine("Диапазон точек четвертой четверти - x > 0, y < 0");
}