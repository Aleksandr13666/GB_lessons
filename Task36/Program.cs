// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



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

int[] NegativPositions(int[] array)
{
    int count = array.Length;
    int index = 1;
    int summ = 0;
     while(index < count)
    {
        summ += array[index];
        index+=2;
    }
    return new int[]{summ};
}

int[] arr = CreateArray(4, 1, 6);
PrintArray(arr);
int[] negPosition = NegativPositions(arr);
Console.WriteLine($"Summ numbers of the negative positions is {negPosition[0]}");


// Задачи 34 и 38 - ОК!
// // По задаче 36 решение рабочее, корректное. Сообщение вывода "Summ numbers of the negative positions..." не соответствует фактическому результату - сумме на нечётных позициях.
// // Спасибо.