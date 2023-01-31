// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

