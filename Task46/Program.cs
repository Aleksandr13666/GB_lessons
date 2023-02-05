// 46. Задайте двумерный массив размером Х х У,
// заполненный случайными целыми числами.
// Х = 3, У = 4

// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1 


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    // for (int i = 0; i < rows; i++)
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
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 4} | ");
            else Console.Write($"{matr[i, j], 4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrix(3, 4, -100, 100);
PrintMatr(array2D);