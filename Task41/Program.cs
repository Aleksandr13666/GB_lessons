// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3




Console.WriteLine("Input size of array: ");
int sizeArr = int.Parse(Console.ReadLine());

int[] arr = CreateArray(sizeArr);
PrintArray(arr);
int[] positiveNum = PositiveNum(arr);
Console.WriteLine($"Positive numbers {positiveNum[0]}");

int[] CreateArray (int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Input element of array: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int[] PositiveNum(int[] arr)
{
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0 ) index++;
    }
    return new int[]{index};
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