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

// Здравствуйте, Александр!
// Задачи 2 и 6 - ОК!
// По задаче 4 решение рабочее, но неоптимальное. Лишнее (дублирующее) сравнение во втором условии.
// Здесь лучше использовать алгоритм с переменной max как в задаче про гири из лекции.
// По задаче 8 решение рабочее, но усложнено. Можно проще:

// int count = 1;
// while (count <= num)
// {
// if (count % 2 == 0)
// {
// Console.WriteLine(count);
// }
// count++;
// }

// Спасибо.