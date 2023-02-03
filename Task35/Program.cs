// 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значение
// которых лежат в отрезке (10, 99)
// (5,18,123,6,2) - 1
// (10,11,12,13,1) - 4




int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int ElementCount(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max)
        count++;
    }
    return count;
}

int[] arr = CreateArrayRndInt(10, -200, 200);
PrintArray(arr);
int digCount = ElementCount(arr, 10, 99);
Console.WriteLine(digCount);