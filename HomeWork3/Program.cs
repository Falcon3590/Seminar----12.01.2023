// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void MaxAndMinDifference(double[] array)
{

    double MaxNumber = array[0];

    double MinNumber = array[0];

    for (int i = 1; i < 10; i++)
    {

        if (array[i] > MaxNumber)
        {
            MaxNumber = array[i];
        }

        if (array[i] < MinNumber)
        {
            MinNumber = array[i];
        }

    }
    Console.Write($"Разниа между максимальным {MaxNumber} и минимальным {MinNumber} элементов массива = {MaxNumber - MinNumber}");
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

Console.Write("Задайте длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
FillArray(array);
PrintArray(array);
Console.WriteLine();
MaxAndMinDifference(array);







