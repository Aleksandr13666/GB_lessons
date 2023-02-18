// 67. Напишите программу которая на вход будет принимать число
// и возвращать сумму его чисел.
// 123 - 6



Console.WriteLine("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());

int summ = Summ(num);
Console.WriteLine($"{summ}");



int Summ(int num)
{
    if (num == 0) return 0;
    return num % 10 + Summ (num / 10);
}


