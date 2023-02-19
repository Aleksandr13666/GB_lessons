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

void MyFind(int[,] matr, int xPos, int yPos)
{

    if(xPos < 0 | xPos > matr.GetLength(0)-1 | yPos < 0 | yPos > matr.GetLength(1)-1)
    {
        Console.WriteLine("this index is does not exist");
    }
    else
    {
        Console.WriteLine($" Digit of the element is {matr[xPos, yPos]},");
    }
 

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

int[,] myMatr = CreateMatrix(4, 4, 1, 9);
PrintMatr(myMatr);
MyFind(myMatr, xPos, yPos);



// Здравствуйте, Александр!
// Задача 47 - ОК!
// По задаче 50 решение рабочее. В условных выражениях следует использовать оптимизированные логические И и ИЛИ как && и ||
// В задаче 52 неверный результат, т.к. среденее вычисляется с накопленной суммы по всем столбцам. Также недочёт - метод вычисления среднего выводит результаты в консоль. Вывод результатов - другая подзадача.
// Сапсибо.