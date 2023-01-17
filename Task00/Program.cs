// 0. Демонстрация решения 
// Напишите программу, которая  
// 1. на вход принимает число 
// 2. выдает его квадрат (число умноденное на себя). 
// 3. вывод результата 
 
// Например: 
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} равен = {square}");