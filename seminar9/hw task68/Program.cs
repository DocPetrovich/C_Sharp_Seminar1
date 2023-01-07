// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int function = Akerman(m, n);

int Akerman(int m, int n)
{
  if (m == 0)
        {
                return n + 1;
        } 
  else if (n == 0)
        {
                return Akerman(m - 1, 1);
        }
  else
        {
                return Akerman(m - 1, Akerman(m, n - 1));
        }

}

Console.Write($"A(m, n) = {function} ");