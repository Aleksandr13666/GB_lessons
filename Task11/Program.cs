// Напишите программу которая выводит 
// случайное трехзначное число и 
// удаляет втору цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98



int number = new Random().Next(100, 1000);
Console.WriteLine($"Number is: {number}");

int result = DelSecondaryNum(number);

Console.WriteLine($"Result: {result}");

static int DelSecondaryNum(int num)
{
    int agr1 = num / 100;
    int arg2 = num % 10;
    int result = agr1 * 10 + arg2;
    return result;
}

