﻿// 19. Напишите программу которая принимает на вход
// пятизначное число и проверяет, является ли он
// палиндромом.
// 14212 - Нет 
// 23432 - Да


Console.WriteLine("Input a five digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Polyndrome(int num)
{
   int n = 0;
   while( n < num)
   {
    n = 10 * n + num % 10;
    num /= 10;
   }
return num == n || num == n / 10 ;
}

Console.WriteLine(Polyndrome(number));