// 32. Напишите программу замены элементов
// массива: положительные элементы заменяются на отрицательные 
// и наоборот.
// (-4,-8, 8, 2) - (4, 8 ,-8, -2)



void InvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}

int[] CreateArray (int size, int min, int max)
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
        if(i < arr.Length - 1)Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] array = CreateArray(12, -9, 9);
PrintArray(array);
Console.WriteLine();
InvertArray(array);
PrintArray(array);