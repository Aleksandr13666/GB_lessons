// 39. Напишите программу которая перевернет одномерный массив
// (1.2.3.4.5) - (5.4.3.2.1)




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

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)//2
    {
        int temp = array[i]; //2
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
ReverseArray(arr);
Console.WriteLine();
PrintArray(arr);

Array.Reverse(arr);
Console.WriteLine();
PrintArray(arr);