Console.WriteLine("Напишите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число C: ");
int c = Convert.ToInt32(Console.ReadLine());
if(a>b && a>c)
{
    Console.WriteLine($"Наибольшее число {a}");
}
else if (b>a && b>c)
{
    Console.WriteLine($"Наибольшее число {b}");
}
else
{
    Console.WriteLine($"Наибольшее число {c}");
};