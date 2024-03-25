//Напишите программу, которая перевернёт одномерный массив
//(первый элемент станет последним,
// второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {

        int[] array = { 5, 2, 5, 3, 0, 4, 7, 5, 3, 5, 8, 8, 2, 5, 5, 2, 5, 2, 6, 5, 2 };

        int[] reversedArray = ReverseArray(array);

        Console.Write("\nИсходный массив: ");

        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.Write("\nПеревернутый массив: ");
        foreach (int number in reversedArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static int[] ReverseArray(int[] array)

    {
        int[] reversedArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - i - 1];
        }

        return reversedArray;
    }
}