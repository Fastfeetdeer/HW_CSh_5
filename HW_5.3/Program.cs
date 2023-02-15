// ДЗ 5.3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Инициализация программы");
Console.WriteLine("Задаётся массив заполненный вещественными числами");

int[] array = GetRandomArray(10, 0, 999);
int max = maxNumbArr(array);
int min = minNumbArr(array);


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

int maxNumbArr(int[] array) 
{
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }

    return max;
}    

int minNumbArr(int[] array) 
{
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }

    return min;
}    
Console.WriteLine($"Задан массив [{string.Join(", ", array)}], Min элемент = {min}, Max элемент = {max}, Разница между Min и Max = {max - min}");
Console.WriteLine("Программа завершила работу");