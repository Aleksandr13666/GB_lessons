// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]




int[] arr = { 1, 2, 5, 7, 19, 6, 1, 33 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arr);

// Задача 25 - ОК!
// По задаче 27 решение рабочее для положительных чисел. Нужна проверка ввода на отрицательные числа, чтобы не было некорректных результатов.
// По задаче 29 создание/заполнение массива нужно реализовать отдельным методом, заполнить случайными числами, т.к. конкретные в условии не указаны. На семинаре была аналогичная задача.
// По итогу 5-.
// Спасибо.