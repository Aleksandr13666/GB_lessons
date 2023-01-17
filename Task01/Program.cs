// 1. Напишите программу которая на вход принимает
// числа и проверяет, является ли первое число квадратом 
// второго. 
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите квадрат числа: ");
int square = Console.Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число квадрат которого вы ввели: ");
int number = Console.Convert.ToInt32(Console.ReadLine());
if (square/2 == number)
{
    Console.WriteLine($"Число {square} является квадратом числа {number}");
}
else
{
    Console.WriteLine($"Число {square} не является квадратом числа{number}");
}