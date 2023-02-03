// 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считается первый и послений элемент, второй 
// и предпоследний и т.д. Результат в новый массив.
// (1,2,3,4,5) - 5 8 3
// (6,7,3,6) - 36 21



internal class Program
{
    private static void Main(string[] args)
    {
        int[] CreateArrayRndInt(int size, int min, int max)
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
                if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
                else Console.Write($"{arr[i]}");
            }
            Console.Write("]");
        }

        int[] SumElements(int[] myArray)
        {
            int size = myArray.Length / 2;
            if (myArray.Length % 2 == 1) size += 1;
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = myArray[i] * myArray[myArray.Length - 1 - i];
            }
            if (myArray.Length % 2 == 1) myArray[size -1] = myArray[myArray.Length / 2];
            return newArray;
        }

        int[] arr = CreateArrayRndInt(9, 1, 9);
        PrintArray(arr);
        int[] newArr = SumElements(arr);
        Console.WriteLine();
        PrintArray(newArr);
    }
}