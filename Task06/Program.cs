Console.WriteLine("Напишите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
{
    Console.WriteLine("Число чётное.");
}
else
{
    Console.WriteLine("Число не чётное.");
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