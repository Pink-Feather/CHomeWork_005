// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] RandArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int EvenNumberArray(int[] array)
{
    int count = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] % 2 ==0) count++;
    }
    return count;
}

int[] array = RandArray(10, 100, 999);
Console.WriteLine(string.Join(",", array));
Console.WriteLine($"Количество четных элементов в массиве: {EvenNumberArray(array)}");