// ДЗ 5.2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Инициализация программы");
Console.WriteLine("Задаётся массив заполненный случайными  числами");
int[] array = GetRandomArray(10, -999, 999);
int sum = sumOddNumber(array);

int[] GetRandomArray(int Length, int minEl, int maxEl)
{
    int[] array = new int[Length];
    Random random = new Random();

    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minEl, maxEl+1);
    }
    return array;
}

int sumOddNumber(int[] array)
{
    int sum = 0;

    for (int i = 0;  i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
            i++;
        }
        else 
        {
            i++;
        }
    }
    return  sum;
}

Console.WriteLine($"Полученный массив [{string.Join(", ", array)}] - {sum} сумма элементов на нечетной позиции");
Console.WriteLine("Программа завершила работу");