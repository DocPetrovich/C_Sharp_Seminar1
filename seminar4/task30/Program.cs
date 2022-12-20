// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями
// и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8]; //int[] array = new int[new Random().Next(0, 9)]; размер массива случайный от 1 до 8.
for (int i = 0; i < 8; i++) //while (i <= (array.Length - 1))
{
    array[i] = new Random().Next(0, 2);
}
Console.WriteLine(string.Join(", ", array)); //Console.WriteLine($"[{string.Join(", ", array)}]");