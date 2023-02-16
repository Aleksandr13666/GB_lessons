// 55. Задайте двумерный массив. Напишите программу которая заменяет 
// строки на столбцы. В случае если это невозможно, программа 
// должна вывести сообщение для пользователя.

int[,] createMatrix = CreateMatrix(4, 4, 1, 9);
PrintMatr(createMatrix);
Console.WriteLine();

if(CheckMatrix(createMatrix))
{
    PrintMatr(ReplaceMatr(createMatrix));
}
else
{
    Console.WriteLine("Matrix is not square.");  
}


bool CheckMatrix(int[,] matrix)
{
   return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] ReplaceMatr(int[,] matrix)
{
    int[,] myMatr = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          myMatr[j, i] = matrix[i, j];   
        }
    }
    return myMatr;
}

int[,] CreateMatrix(int row, int columns, int min, int max)
{
    int[,] matr = new int[row, columns]; // 0, 1
    Random rnd = new Random();

    // for (int i = 0; i < rows; i++)
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
            // matr[i, j] = i + j;
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