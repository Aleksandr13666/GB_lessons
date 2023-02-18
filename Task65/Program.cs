
// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

void NaturalNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbers(numM + 1, numN);
    }
    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbers(numM - 1, numN);
    }
    else Console.WriteLine(numN);
}


Console.Write("Введите число M: ");
int number1 = UserInput();
Console.Write("Введите число N: ");
int number2 = UserInput();
NaturalNumbers(number1, number2);