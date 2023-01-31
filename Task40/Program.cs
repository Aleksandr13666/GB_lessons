// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.




Console.WriteLine("Input first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Treangle(int num1, int num2, int num3)
{
    return num1 + num2 > num3 || num2 + num3 > num1 || num1 + num3 > num2;
}
bool tre = Treangle(number1, number2, number3);
Console.WriteLine(tre ? "yes":"no");