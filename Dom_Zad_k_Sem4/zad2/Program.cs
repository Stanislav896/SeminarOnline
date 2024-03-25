//Задайте массив заполненный случайными
//трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] array = Enumerable.Range(1, 10)
            .Select(i => rnd.Next(100, 1000))
            .ToArray();

        Console.WriteLine(string.Join(" , ", array)); // Вывод всех чисел в одну строку

        int evenCount = array.Count(i => i % 2 == 0);

        Console.WriteLine($"В массиве {evenCount} чётных чисел.");
    }
}


