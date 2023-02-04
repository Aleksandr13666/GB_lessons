// 45. Напишите прошграмму которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.


int[] firstArr = CreateArray(10, 5, 25);
PrintArray(firstArr);
Console.WriteLine();
int[] copyArr = CopyArr(firstArr);
PrintArray(copyArr);


int[] CopyArr(int[] arr)
{
    int[] myArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        myArray[i] = arr[i];
    }
    return myArray;
}


int[] CreateArray (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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