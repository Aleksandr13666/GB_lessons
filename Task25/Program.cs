// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



Console.WriteLine("Input a number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree of number: ");
int numB = Convert.ToInt32(Console.ReadLine());


void Degree(int numA, int numB)
{
    Console.WriteLine(Math.Pow(numA, numB) + "");
}

if (numB > 0)
{
    Degree(numA, numB);
}

else
{
    Console.WriteLine("wrong input. Enter natural degree of number.");
}


