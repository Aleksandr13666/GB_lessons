Console.WriteLine("Задайте день недели в числовом формате: ");
int num = Convert.ToInt32(Console.ReadLine());
switch(num)
{
    case 1: Console.WriteLine("Monday");
    return 0;
    case 2: Console.WriteLine("Tuesday");
    return 0;
    case 3: Console.WriteLine("Wednesday");
    return 0;
    case 4: Console.WriteLine("Thursday");
    return 0;
    case 5: Console.WriteLine("Friday");
    return 0;
    case 6: Console.WriteLine("Saturday");
    return 0;
    case 7: Console.WriteLine("Sunday");
    return 0;
    default: Console.WriteLine("Wrong input");
    return 0;
};