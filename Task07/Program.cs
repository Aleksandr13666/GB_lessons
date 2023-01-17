Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int div = num % 10;
Console.WriteLine("Остаток от деления: " + div);