// 30. Напишите программу, которая выводит массив из 8 элементов,
// заполненый нулями и единицами в случайном порядке.
// [1,0,0,0,1,1,1,0]


void FillArr(int [] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while(index < length)
    {
        numbers[index] = new Random().Next(0, 2);
        index++;
    }
}
 void PrintArr(int [] num)
 {
    int count = num.Length;
    int nums = 0;
    while(nums < count)
    {
        Console.WriteLine(num[nums]);
        nums++;
    }
 }

int [] array = new int[8];

FillArr(array);
PrintArr(array);