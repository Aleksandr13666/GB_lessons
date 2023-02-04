// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] arr = {3.5, 7.1, 22.9, 2.3, 78.5};

double diff = Diff(arr);
PrintArray(diff);
double[] Diff(double[] array)
{
    double biggest = 0;
    double small = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > biggest) biggest = array[i];
        else if(array[i] < small) small = array[i];
        index++;
    }
    double difference = biggest - small;
    return difference;
    
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}




