// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка





int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns]; // 0, 1
    Random rnd = new Random();


    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matr;
}

void PrintMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4} | ");
            else Console.Write($"{matr[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

void RowSumm(int[,] matr)
{
    int summ = 0;
    int minimum = int.MaxValue;
    int index = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            summ += matr[i, j];
        }
        Console.WriteLine($"summ of the row {i + 1} = {summ}");
        if (summ < minimum)
        {
            minimum = summ;
            index = i + 1;
        }

    }

    Console.WriteLine($"Minimal summ {minimum} in row number {index}");
}


int[,] array2D = CreateMatrix(5, 6, 1, 15);
PrintMatr(array2D);
RowSumm(array2D);