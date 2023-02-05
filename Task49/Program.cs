// 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.

//  1  4  7  2     1  4  49  2
//  5  9  2  3     5  9  2   3
//  8  4  2  4     64 4  4   4





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

void SquareNum(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           if(i % 2 == 0 && j % 2 == 0)
           {
            matr[i, j] = matr[i, j] * matr[i, j];
           }
        }
    }

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

int[,] array2D = CreateMatrix(6, 8, 2, 10);
PrintMatr(array2D);
Console.WriteLine("");
SquareNum(array2D);
PrintMatr(array2D);