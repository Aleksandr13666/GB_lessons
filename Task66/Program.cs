
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int NaturalNumbers(int numM, int numN)
{
    if (numM == 0) return (numN * (numN + 1)) / 2;
    else if (numN == 0) return (numM * (numM + 1)) / 2;
    else if (numM == numN) return numM;
    else if (numM < numN) return numN + NaturalNumbers(numM, numN - 1);
    else return numN + NaturalNumbers(numM, numN + 1);
}


Console.Write("Введите число M: ");
int number1 = UserInput();
Console.Write("Введите число N: ");
int number2 = UserInput();
int naturalNumbers = NaturalNumbers(number1, number2);
Console.WriteLine($"{naturalNumbers}");