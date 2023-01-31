// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



Console.WriteLine("Input a number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree of number: ");
int numB = Convert.ToInt32(Console.ReadLine());

int degree = Degree(numA, numB);
// void Degree(int numA, int numB)
// {
//     Console.WriteLine(Math.Pow(numA, numB) + "");
// }
int Degree(int numA, int numB)
{
    int deg = 1;
    for (int i = 0; i < numB; i++)
    {
        deg *= numA; 
    }
    return deg;
}

if (numB > 0)
{
    Console.WriteLine($"{degree}");
}

// if (numB > 0)
// {
//     Degree(numA, numB);
// }

else
{
    Console.WriteLine("wrong input. Enter natural degree of number.");
}


