// 53. Задайте двумерный массив. Напишиите программу 
// которая меняет первую и последнюю строку местами.



int[,] createMatrix = CreateMatrix(10, 10, 1, 100);
PrintMatrix(createMatrix);
Console.WriteLine("");
MatrixRenew(createMatrix);
PrintMatrix(createMatrix);

int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],8} |");
            else Console.Write($"{matrix[i, j],8} ");
        }
        Console.WriteLine("]");
    }
}

void MatrixRenew(int[,] matrixInput)
{
    int temp;
    for (int i = 0; i < matrixInput.GetLength(1); i++)
    {
        temp = matrixInput[0, i];
        matrixInput[0, i] = matrixInput[matrixInput.GetLength(0) - 1, i];
        matrixInput[matrixInput.GetLength(0) - 1, i] = temp;

    }
}