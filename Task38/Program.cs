// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] arr = { 3.5, 7.1, 22.9, 2.3, 78.5 };
PrintArray(arr);
Console.WriteLine("");
double diff = Diff(arr);
Console.WriteLine($"{diff}");

double Diff(double[] array)
{
    double max = 0;
    double min = arr[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    double difference = max - min;
    return difference;

}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


// Задачи 34 и 38 - ОК!
// // // По задаче 36 решение рабочее, корректное. Сообщение вывода "Summ numbers of the negative positions..." не соответствует фактическому результату - сумме на нечётных позициях.
// // // Спасибо.

