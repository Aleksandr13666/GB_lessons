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