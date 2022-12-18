// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату по оси X для переменной A:");
double xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y для переменной A:");
double ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Z для переменной A:");
double za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси X для переменной B:");
double xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y для переменной B:");
double yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Z для переменной B:");
double zb = Convert.ToInt32(Console.ReadLine());

double resX = Math.Pow(xb - xa, 2);
double resY = Math.Pow(yb - ya, 2);
double resZ = Math.Pow(zb - za, 2);

double res = Math.Sqrt(resX + resY + resZ);

Console.WriteLine($"Расстояние между двума точками : {res:f2}");