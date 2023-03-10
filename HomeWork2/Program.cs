// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 // [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

int SumElements(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
             sum += array[i];
        }
    }

    return sum;
}

Console.Write("Задайте длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях = {SumElements(array)}");