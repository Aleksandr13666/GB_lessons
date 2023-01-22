using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
// 20. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние
// между ними в 2-мерном пространстве.



Console.WriteLine("Input X coordinate of dot A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate of dot A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X coordinate of dot B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate of dot B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double hypotenuse = Hypotenuse(x1, x2, y1, y2);

Console.WriteLine($"Hypotenuse of two dots, A & B = {hypotenuse}");

double Hypotenuse(int x1, int x2, int y1, int y2)
{
     double result = Math.Sqrt((x1 - y1) * (x1 - y1) + (x2 - y2) * (x2 - y2));
     double res = Math.Round(result, 2, MidpointRounding.ToZero);
     return res;
}