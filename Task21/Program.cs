// 21. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между 
// ними в 3-мерном пространстве.
// А(3,6,8); В (2,1,-7) -> 15,84

Console.WriteLine("Input X coordinate of dot A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate of dot A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate of dot A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X coordinate of dot B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X coordinate of dot B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate of dot B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double hypotenuse = Hypotenuse(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Hypotenuse of two dots, A & B = {hypotenuse}");

double Hypotenuse(int x1, int y1, int z1, int x2, int y2, int z2)
{
     double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
     double res = Math.Round(result, 2, MidpointRounding.ToZero);
     return res;
}

// Здравствуйте, Александр!
// По задаче 19 хорошее универсальное решение для положительных чисел. Отрицательное число тоже может быть палиндромом, т.к. математически сравниваются цифры, знак при этом не играет никакой роли.
// Задачи 21 и 23 - ОК!
// Спасибо.