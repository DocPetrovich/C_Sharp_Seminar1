// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

const int SIZE =6;
const int LEFTRANGE=1;
const int RIGTHRANGE=9;
int[] GetRandomArray(int size, int leftRange, int rigthRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rand.Next(leftRange,rigthRange +1);
    }

    return array;
}
int[] arr =GetRandomArray(SIZE,LEFTRANGE,RIGTHRANGE);
Console.WriteLine(string.Join(",", arr));

int count=0;
for (int i = 0; i < SIZE; i++)
{
    if (i%2 !=0)
    {
        count = arr[i]+ count;
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций массива = {count}");