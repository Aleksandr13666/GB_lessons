﻿// 17. Напишите программу, которая принимает на вход
// координаты точки (Х и У), причём Х != 0 и У !=0 и
// выдаёт номер четверти плоскости, в которой 
// находится эта точка.


Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);

string result = quarter > 0
                     ? $"Координаты соответствуют четверти -> {quarter}"
                     : "Введены не корректные координаты.";

Console.WriteLine(result);                     

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}