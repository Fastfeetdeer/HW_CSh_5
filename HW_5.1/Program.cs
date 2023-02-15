// ДЗ 5.1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Инициализация программы");
Console.WriteLine("Задаётся массив заполненный случайными положительными трёхзначными числами");
int[] array = GetRandomArray(10, 100, 999);
int count = findNumber(array);

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

int findNumber(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
           count++;
        }
    }
    return count;
}
Console.WriteLine($"Полученный массив [{string.Join(", ", array)}] - {count} четных чисел");
Console.WriteLine("Программа завершила работу");