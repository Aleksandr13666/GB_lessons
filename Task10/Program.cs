// 10. Напишите программу, которая принимает на 
// вход трехзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 - 5
// 782 - 8
// 918 - 1

Console.WriteLine("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDig = SecondDigit(number);

int SecondDigit(int num)
{
    int num1 = number / 10;
    int num2 = num1 % 10;
    return num2;
}

if (number >= 100 && number < 1000)
{

    Console.WriteLine(secondDig);

}
else Console.WriteLine("Wrong input");


// Здравствуйте, Александр!
// По задачам 10 и 13 решения рабочие. Общее замечание - сначала нужно выполнить проверку исходного числа, а уже по результату выполнять вычисление. Также необходмо ещё учесть ввод отрицательных чисел.
// По задаче 15 решение рабочее, но избыточное - название дня недели не требуется выводить.
// По итогу 5-.
// Спасибо.