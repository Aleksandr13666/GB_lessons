// 18. Напишите программу, которая по заданному номеру четверти показывает
// возможные координаты точки (Х и У).



Console.WriteLine("Input number of quarter: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = Coordinate(number);

Console.WriteLine(result);

string Coordinate(int num)
{
    if (num == 1) return ($"Координаты соответствуют значениям Х и У -> x > 0 , y > 0");
    if (num == 2) return ($"Координаты соответствуют значениям Х и У -> x < 0 , y > 0");
    if (num == 3) return ($"Координаты соответствуют значениям Х и У -> x < 0 , y < 0");
    if (num == 4) return ($"Координаты соответствуют значениям Х и У -> x > 0 , y < 0");
    return ("Введены не корректные координаты");
}