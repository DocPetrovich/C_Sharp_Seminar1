// Задача №20. Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D-пространстве


Console.WriteLine("Введите координату по оси X для переменной A:");
double xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y для переменной A:");
double ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси X для переменной B:");
double xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y для переменной B:");
double yb = Convert.ToInt32(Console.ReadLine());

double resX = Math.Pow(xb - xa, 2);
double resY = Math.Pow(yb - ya, 2);
double res = Math.Sqrt(resX + resY);
Console.WriteLine($"Расстояние между двума точками : {res:f2}");