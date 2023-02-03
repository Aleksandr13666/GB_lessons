// : Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



Console.WriteLine("Input a digit: ");
int digit = Convert.ToInt32(Console.ReadLine());

int binary = Binary(digit);


int Binary(int dig)
{
    int result = 0;
    int number = 1;
    while (dig > 0)
    {
        result += dig % 2 * number;
        dig /= 2;
        number *= 10;
    }
    return result;
}

Console.WriteLine(binary);