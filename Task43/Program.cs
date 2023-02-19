// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



using System;

Console.WriteLine("Input meaning first direct line B1: ");
double B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input meaning second direct line K1: ");
double K1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input meaning first direct line B2: ");
double B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input meaning second direct line K2: ");
double K2 = Convert.ToInt32(Console.ReadLine());


double intersectionX = IntersectionX(B1, K1, B2, K2);

double intersectionY = IntersectionY(B1, K1, B2, K2);

PrintRez(intersectionX, intersectionY);

double IntersectionX(double B1, double K1, double B2, double K2)
{
    double x = 0;
    if ((K1 == K2) && (B1 == B2))
        Console.WriteLine("Straight lines match");
    else if (K1 == K2)
        Console.WriteLine("Straight parallel");
    else
    {
        x = (B2 - B1) / (K1 - K2);
    }
    return Math.Round(x, 2, MidpointRounding.ToZero);
}
double IntersectionY(double B1, double K1, double B2, double K2)
{
    double y = 0;
    if ((K1 == K2) && (B1 == B2))
        Console.WriteLine("Straight lines match");
    else if (K1 == K2)
        Console.WriteLine("Straight parallel");
    else
    {
        y = K1 * ((B2 - B1)) / ((K1 - K2)) + B1;
    }
    return Math.Round(y, 2, MidpointRounding.ToZero);
}

void PrintRez(double IntersectionX, double IntersectionY)
{
    Console.WriteLine($"Intersection point is:{intersectionX},{intersectionY} ");
}


// Задача 41 - ОК!
// // По задаче 43 решение рабочее, структура неверная. Проверка данных должна выполняться один раз до вычислений (вне этих методов).
// // Имена переменных и параметров в C# должны начинаться с маленькой буквы! В одной области видимости не должно быть одноимённых переменных.
// // По итогу 5-.
// // Спасибо.