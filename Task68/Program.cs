// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


using System.Diagnostics.CodeAnalysis;
using System.Reflection;

Console.Write("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int akkerman = Akkerman(number1, number2);
Console.WriteLine($"{akkerman}");

int Akkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if ((n > 0) && (m == 0))
    {
        return Akkerman(n - 1, 1);
    }
    else if ((n > 0) && (m > 0))
    {
        return Akkerman(n - 1, Akkerman(n, m - 1));
    }
    else return n + 1;
}

// По задаче 64 решение рабочее. Недочёт - отсутствует проверка исходного числа на натуральность, при отрицательных значениях программа 
// попадает в бесконечную рекурсию, что приводит к переполнению стека.
// По задаче 66 решение рабочее. Первые две строки в методе лишние.
// По задаче 68 решение рабочее, но не оптимальное. Можно оптимизировать и улучшить вычислимость функции, 
// если убрать последний return (всю строку), а в строке 27 убрать условие, оставить только возврат функции. else в методе не нужны.