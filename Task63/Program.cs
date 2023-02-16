// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"




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