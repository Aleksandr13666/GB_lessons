
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
