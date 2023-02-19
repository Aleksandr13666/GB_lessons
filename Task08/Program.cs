Console.Write("Напишите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count <= num)
{
    if (count % 2 == 0  && count !=0)
    {
        Console.WriteLine(count + "");
        if (count % 2 !=0)
        {
        continue;
        }
    }
    count++;
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