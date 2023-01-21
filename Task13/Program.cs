// 13. Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 - 5
// 78 - нет
// 32679 - 6

Console.WriteLine("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDig = ThirdDigit(number);

if (number < 100)
Console.WriteLine("Wrong input. Insert 3 digits number or more");
else
{
    Console.WriteLine(thirdDig);
}

int ThirdDigit(int num)
{
    while (num >= 1000) 
    // num = num / 10;
    num /=10;
    int res = num % 10;
    return res;
}
