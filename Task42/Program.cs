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
    for(int i = 0; i < dig; i++)
    {
        result += dig % 2;
        dig /= 2; 
    }
    return result;
}

Console.WriteLine(binary);