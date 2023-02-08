// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание,
//  что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Input X position of element: ");
int xPos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y position of element: ");
int yPos = Convert.ToInt32(Console.ReadLine());

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

void MyFind(int[,] matr)
{

      for (int i = 0; i < matr.GetLength(0); i++)
      {
       for (int j = 0; j < matr.GetLength(1); i++)
       {
          if(matr[i, j] == matr[xPos, yPos])
          {
            Console.WriteLine($"Number of position is: {matr[i, j]}");
          }
          else Console.WriteLine("Out of index.");
       } 
      }
    //   return new int[,]{};
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

int[,] myMatr = CreateMatrix(8, 8, 1, 9);
PrintMatr(myMatr);
MyFind(myMatr);
// PrintMatr(myMatr);