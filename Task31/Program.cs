// 31. Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка (-9: 9). Найдите
// сумму отрицательных и положительных элементов массива.
// Например в массиве (3,9,-8,1,0,-7,2,-1,8,-3,-1,6)
// сумма положительных чисел равна 29, сумма отрицательных
// равна -20.



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

int[] GetSumNegPosNumbers(int [] arr)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sumNeg += arr[i];
        else sumPos += arr[i];
    }
    return new int[]{sumNeg, sumPos};
}

int[] array = CreateArray(12, -9, 9);
PrintArray(array);
int[] sumNegPosNums = GetSumNegPosNumbers(array);
Console.WriteLine($"Summ negative numbers is {sumNegPosNums[0]}");
Console.WriteLine($"Summ positive numbers is {sumNegPosNums[1]}");