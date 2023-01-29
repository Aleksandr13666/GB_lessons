// 28. Напишите программу, которая принимает на вход число (N)
// и выдаёт произведение чисел от 1 до N.
// 5 - 120
// 4 - 24



Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int mult = Mult(number);

int Mult(int number)

{
   
   int count = 1;
   int i = 1 ;
   while(count <= number)
   {
       i *= count;
       count++;
   }
   return i;

}

Console.WriteLine($"Sum all number is {mult}");