// 69. Напишите программу, которая на вход принимает два числа А и в
// и возводит число А в целую степень В с помощью рекурсии.



Console.WriteLine("Input 1 digit: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 2 digit: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int mult = MultNums(number1, number2);
Console.WriteLine($"{mult}");

int MultNums(int num1, int num2)
{
    if(num2 == 0)return 1;
    else return num1 * MultNums(num1, num2 - 1);
}