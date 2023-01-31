// 33. Задайте массив. Напишите программу, ктороая
// определяет, присутствует ли заданное число
// в массиве.
// 4 - (6,7,8,245,38) - нет
// 2 - (6,8,5,2,64,8890) - да




Console.WriteLine("Input a digit for find: ");
int number = Convert.ToInt32(Console.ReadLine());

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

int FindNum(int[] array, int number)
{
    int n = array.Length;
    int index = 0;
    int find = -1;
    while(index < n)
    {
        if(array[index] == number)
        {
            find = index;
            break;
        }
        index++;
    }
    return find;


}

int[] array = CreateArray(12, -9, 9);
PrintArray(array);
Console.WriteLine();
int findNum = FindNum(array, number);
Console.WriteLine(findNum);
