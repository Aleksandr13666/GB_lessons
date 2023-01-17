Console.WriteLine("Напишите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else
{
    Console.WriteLine($"Число {b} больше {a}");
};