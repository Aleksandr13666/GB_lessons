Console.WriteLine("Input digit of a week: ");
int num = Convert.ToInt32(Console.ReadLine());

switch(num)
{
    case 1: Console.WriteLine("Is a Monday. Not a weekend");
    break;
    case 2: Console.WriteLine("Is a Tuesday. Not a weekend");
    break;
    case 3: Console.WriteLine("Is a Wednesday. Not a weekend");
    break;
    case 4: Console.WriteLine("Is a Thursday. Not a weekend");
    break;
    case 5: Console.WriteLine("Is a Friday. Not a weekend");
    break;
    case 6: Console.WriteLine("Is a Saturday. It's a weekend");
    break;
    case 7: Console.WriteLine("Is a Sunday. It's a weekend");
    break;
    default: Console.WriteLine("Wrong input");
    break;
}

Console.WriteLine(num);


// Здравствуйте, Александр!
// По задачам 10 и 13 решения рабочие. Общее замечание - сначала нужно выполнить проверку исходного числа, а уже по результату выполнять вычисление. Также необходмо ещё учесть ввод отрицательных чисел.
// По задаче 15 решение рабочее, но избыточное - название дня недели не требуется выводить.
// По итогу 5-.
// Спасибо.