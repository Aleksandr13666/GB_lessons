﻿// 23. Напишите программу, которая принимает на вход число и выдаёт 
// таблицу кубов чисел от 1 до введенного числа.
// 3- 1,8,27
// 5- 1,8,27,64

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
   int count = 1;
   while (count <= num)
   {
     Console.WriteLine($"Cube of {count, 4} is {count * count * count, 2}");
     count++;
   }

}
Cube(number);