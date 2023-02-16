// 55. Задайте двумерный массив. Напишите программу которая заменяет 
// строки на столбцы. В случае если это невозможно, программа 
// должна вывести сообщение для пользователя.



int[,] CreateMatrix(int row, int columns, int min, int max)
{
    int[,] matr = new int[row, columns]; // 0, 1
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
