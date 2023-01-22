// 22. Напишите программу которая на вход принимает число
// N и выдаёт таблицу квадратов от 1 до числа N.
// 5 -> 1, 4, 9 ,16 ,25


Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
   int count = 1;
   while (count <= num)
   {
     Console.WriteLine($"square of {count, 4} is {count * count, 2}");
     count++;
   }

}
Square(number);
