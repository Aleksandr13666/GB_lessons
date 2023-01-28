// 26. Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр
// в числе.
// 456 - 3
// 34 - 2
// 2456346 - 7


Console.WriteLine("Input a digit: ");
int number = Convert.ToInt32(Console.ReadLine());

int countDigit = CountDigit(number);

Console.WriteLine($"Number of digits is: {countDigit}");

int CountDigit(int num)
{
    if (number < 0) num *= -1;

    int count = 1;

    while(num > 0)
    {
        num = num / 10;
        count ++; 
    }

    return count;
}