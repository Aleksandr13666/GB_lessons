// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] myMatr = CreateDubMatr(3, 4);
PrintMatrix(myMatr);


double[,] CreateDubMatr(int rows, int columns)
{
   double[,] matr = new double [rows, columns];
   Random rnd = new Random();
   for (int i = 0; i < matr.GetLength(0); i++)
   {
    for(int j = 0; j < matr.GetLength(1); j++)
    {
     matr[i, j] = Math.Round(rnd.Next(-100, 100) * 0.1, 1, MidpointRounding.ToZero);
    }
   }
   return matr;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(j < matrix.GetLength(1) - 1)Console.Write($"{matrix[i, j], 8}, | ");
        else Console.Write($"{matrix[i, j], 8}");
    }
    Console.WriteLine("]");
    }
}

// Здравствуйте, Александр!
// Задача 47 - ОК!
// По задаче 50 решение рабочее. В условных выражениях следует использовать оптимизированные логические И и ИЛИ как && и ||
// В задаче 52 неверный результат, т.к. среденее вычисляется с накопленной суммы по всем столбцам. Также недочёт - метод вычисления среднего выводит результаты в консоль. Вывод результатов - другая подзадача.
// Сапсибо.