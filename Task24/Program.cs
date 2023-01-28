// 24. Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 - 28
// 4 - 10



Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number);

int Sum(int number)

{
   
   int count = 1;
   int i = 0 ;
   while(count <= number)
   {
       i += count;
       count++;
   }
   return i;

}

Console.WriteLine($"Sum all number is {sum}");