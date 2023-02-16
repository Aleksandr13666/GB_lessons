// 59. Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// наименьший элемент 1
// получаем
// 9 4 2
// 2 2 6
// 3 4 7

int[,] createMatrix = CreateMatrix(4, 5, 1, 9);
PrintMatr(createMatrix);
Console.WriteLine();
int[] minElementIndex = MinElementIndex(createMatrix);
PrintArray(minElementIndex);
Console.WriteLine();
int [,] deleteMinElement = DeleteMinElement(createMatrix, minElementIndex);
PrintMatr(deleteMinElement);





int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
         matrix[i, j] = rnd.Next(min, max +1);
       }   
    }
    return matrix;
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


int[] MinElementIndex(int[,] matrix)
{
    int[] result = new int[2];
    int min = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) 
            {
                min = matrix[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
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

int[,] DeleteMinElement(int[,] matrix, int[] array)
{
    int delRows = matrix.GetLength(0) - 1;
    int delColumns = matrix.GetLength(1) - 1;
    int[,] resultMatrix = new int[ delRows, delColumns];
    int m =0;
    
    for (int i = 0; i < delRows; i++)
    {
        if(m == array[0])m++;
        int n =0;
       for (int j = 0; j < delColumns; j++)
       {
          if(n == array[1])n++;
          resultMatrix[i, j] = matrix[m, n];
          n++;
       }   
       m++;
    }

    return resultMatrix;
}