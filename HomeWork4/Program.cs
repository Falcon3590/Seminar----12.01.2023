// Задача 30: - HARD необязательная 
// ~1. Напишите программу, которая на вход получает размерность массива. 
// ~2. Далее заполняет его случайными уникальными числами и выводит на экран. 
// ~3. Далее производим сортировку массива от большего к меньшему и выводим на экран. 
// 4. Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат. 
// Встроенные методы работы со списками использовать нельзя.

void FillArray(int[] array)
{
    Console.Write("[ ");

    int i = 0;

    while (i < array.Length)
    {
        Random rnd = new Random();
        int q = rnd.Next(1, 11);
        if (СheckingForMatch(q, array) == true)
        {
            array[i] = q;
            Console.Write(array[i] + " ");
            i++;
        }

    }

    Console.Write("]");
}

bool СheckingForMatch(int n, int[] arr) // Метод проверяет число на совпадение. Правда/Лож
{
    bool run = true;
    for (int i = 0; i < arr.Length; i++)
    {
        if (n == arr[i])
        {
            run = false;
            break;
        }

    }
    return run;
}

void SortingArray(int N, int[] arr)
{
    Console.Write("[ ");

    int[] HelpArr = new int[N];

    for (int i = 0; i < arr.Length; i++)
    {
        int MaxNumber = 0;

        int ind = 0;

        for (int x = 0; x < arr.Length; x++)
        {
            if (MaxNumber < arr[x])
            {
                MaxNumber = arr[x];
                ind = x;
            }

        }

        arr[ind] = 0;

        HelpArr[i] = MaxNumber;

    }

    for (int y = 0; y < arr.Length; y++) // Можно использовать Array.Copy();
    {
        arr[y] = HelpArr[y];
        Console.Write(arr[y] + " ");
    }
    Console.Write("]");
}

void MixingNum(int N, int [] arr)
{
    Random rnd = new Random();

    for (int i = N - 1; i >= 1; i--)
    {
        int q = rnd.Next(1, N + 1) % (i + 1);

        int tmp = arr[q];
        arr[q] = arr[i];
        arr[i] = tmp;
    }

    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

Console.Clear();
Console.Write("Задайте длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array);
Console.WriteLine();
SortingArray(N, array);
Console.WriteLine();
MixingNum(N, array);














