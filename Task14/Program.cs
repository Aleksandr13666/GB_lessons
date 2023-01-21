// 14. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -нет
// 46 - нет
// 161 - два

Console.WriteLine("Input a digit: ");
int number = Convert.ToInt32(Console.ReadLine());

bool multiple = Multiple(number);

Console.WriteLine(multiple ? "Yes" : "No");

bool Multiple(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}




