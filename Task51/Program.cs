// 51. Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали
// с индексами (0,0); (1;1) и т.д.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали 1+9+2=12



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

int NumSum(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        sum += matr[i, i]; 
        // смотри семинар 7
        // for (int j = 0; j < matr.GetLength(1); j++)
        // {
        //     if (i == j)
        //     {
        //         sum += matr[i, j];
        //     }
        // }
    }
    return sum;
}


void PrintMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) -1) Console.Write($"{matr[i, j],4} | ");
            else Console.Write($"{matr[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrix(3, 4, 1, 10);
PrintMatr(array2D);
Console.WriteLine("");
int numSum = NumSum(array2D);
Console.WriteLine(numSum);
PrintMatr(array2D);