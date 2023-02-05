// 48. Задайте двумерный массив размера Х на У,
// каждый элемент в массиве находится по формуле
// Аху = х + у.
// Выведите полученный массив на экран.
// х = 3 у = 4
// 0123
// 1234
// 2345


int[,] CreateMatrix(int rows, int columns)
{
    int[,] matr = new int[rows, columns]; // 0, 1
    // Random rnd = new Random();

    // for (int i = 0; i < rows; i++)
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            // matr[i, j] = rnd.Next(min, max + 1);
            matr[i, j] = i + j;
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
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 4} | ");
            else Console.Write($"{matr[i, j], 4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrix(3, 4);
PrintMatr(array2D);