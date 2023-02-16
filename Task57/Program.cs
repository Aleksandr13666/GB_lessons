// 57. Составить частотный словарь элементовдвумерного массива.
// Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных.
// (1, 9, 9, 0, 2, 8, 0, 9)
// 0 - 2 раза
// 9 - 3 раза
// 8 - 1 раз
// 2 - 1 раз
// 1 - 1 раз


int[,] createMatrix = CreateMatrix(4, 6, 2, 9);
Console.WriteLine();
PrintMatr(createMatrix);
int[] convertToArray = ConvertToArray(createMatrix);
PrintArray(convertToArray);
Array.Sort(convertToArray);
Console.WriteLine();
PrintArray(convertToArray);
FrequencyDictionary(convertToArray);







int[] ConvertToArray(int[,] matrix)
{
    int count = 0;
    int arrSize = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array = new int[arrSize];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
         array[count] = matrix[i, j];
         count++; 
       }   
    }
    return array;
}

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

void FrequencyDictionary(int[] array)
{
    int count = 1;
    int num = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i] == num)
       count++;
       else
       { Console.WriteLine($"Digit {num} is {count}");
          num = array[i];
          count = 1;
       }

    }
    Console.WriteLine($"Digit {num} is {count}");
}