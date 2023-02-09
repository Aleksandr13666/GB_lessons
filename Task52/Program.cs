// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows,columns];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(min, max);
        }
    }
    return matr;
}

void ArithMean(int[,] matr)
{
    double arithmetic = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int i = 0; i < matr.GetLength(0); i++)
      {
        arithmetic += matr[i, j]; 
      }   
      Console.WriteLine($"Arithmetic mean is {arithmetic / matr.GetLength(0)}");
    }
}

void PrintMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
         if(j < matr.GetLength(1)-1) Console.Write($"{matr[i, j], 4} | ");
         else Console.Write($"{matr[i, j],4}");   
        }
        Console.WriteLine("]");
    }
}

int[,] matrix = CreateMatrix(4, 5, 1, 9);
PrintMatr(matrix);
ArithMean(matrix);