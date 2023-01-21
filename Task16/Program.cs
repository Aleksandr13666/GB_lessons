// 16. Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого.
// 5, 25 - да
// -4, 16 - да
// 25, 5 - да
// 8, 9 - нет


Console.WriteLine("Input 1 digit: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 2 digit: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool square = Square(number1, number2);
Console.WriteLine(square ? "Yes" : "No");
bool Square(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

