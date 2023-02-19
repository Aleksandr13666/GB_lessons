﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = 0;

int summNum= SummNum(number);

Console.WriteLine($"Summ of numbers is: {summNum}");

int SummNum(int num)
{
    while(num > 0)
    {
       res +=  num % 10;
       num = num / 10;
    }
    return res;
}

// Задача 25 - ОК!
// По задаче 27 решение рабочее для положительных чисел. Нужна проверка ввода на отрицательные числа, чтобы не было некорректных результатов.
// По задаче 29 создание/заполнение массива нужно реализовать отдельным методом, заполнить случайными числами, т.к. конкретные в условии не указаны. На семинаре была аналогичная задача.
// По итогу 5-.
// Спасибо.