// FIB


Console.WriteLine("input a digit: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] fibonacci = Fib(number);
PrintArray(fibonacci);

int[] Fib(int num)
{
    int[] fib = new int[number] ;
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i < num; i++)
    {
       fib[i] = fib[i - 2] + fib[i - 1];   
    }
    return fib;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

