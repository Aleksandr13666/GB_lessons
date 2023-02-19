// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] matrix1 = CreateMatrix(5, 5, 1, 9);
int[,] matrix2 = CreateMatrix(5, 5, 1, 9);
PrintMatr(matrix1);
Console.WriteLine();
PrintMatr(matrix2);
Console.WriteLine();
PrintMatr(NewMatr(matrix1 , matrix2));


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
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
        if(j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 4} |");
        else Console.Write($"{matr[i, j], 4}"); 
      }   
      Console.WriteLine("]");
    }
}


int[,] NewMatr(int[,] matr1, int[,] matr2)
{
    int[,] newMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if(matr1.GetLength(1) == matr2.GetLength(0))
    {
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
          for (int j = 0; j < matr2.GetLength(1); j++)
          {
            
            for (int index = 0; index < matr2.GetLength(0); index++)
            {
                newMatr[i, j] += matr1[i, index] * matr2[index, j]; 
            }
          }   
        }
    } 
    return newMatr;
}

// Задача 54 - ОК!
// По задаче 56 решение рабочее. Недочёт - метод, выполняющий вычисления, выводит результат в консоль. Вывод данных - другая подзадача.
// В задаче 58 не хватает проверки размеров исходных матриц на допустимость для умножения.
// По итогу 5-.
// Спасибо.