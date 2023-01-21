Console.WriteLine("Input digit: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input divider: ");
int divider = Convert.ToInt32(Console.ReadLine());

// void Multiple(int num, int div)
// {
//     if(num % div == 0)
//     {
//         Console.WriteLine($"{number} кратно {divider}");
//     }
//     else Console.WriteLine($"{number} при делении на {divider} имеет остаток = {num % div}");
// };

// Multiple(number, divider);
int remains = Remains(number, divider);

int Remains(int number, int divider)
{
    return number % divider;
    
}
if(remains == 0)
{
    Console.WriteLine("Нет остатка.");
}
else
Console.WriteLine($"остаток {remains}");

