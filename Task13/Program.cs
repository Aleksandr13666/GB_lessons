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



// Здравствуйте, Александр!
// По задачам 10 и 13 решения рабочие. Общее замечание - сначала нужно выполнить проверку исходного числа, а уже по результату выполнять вычисление. Также необходмо ещё учесть ввод отрицательных чисел.
// По задаче 15 решение рабочее, но избыточное - название дня недели не требуется выводить.
// По итогу 5-.
// Спасибо.