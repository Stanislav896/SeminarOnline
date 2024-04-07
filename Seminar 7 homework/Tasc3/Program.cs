// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.



int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Пример массива
PrintArrayReverse(array, array.Length - 1);

static void PrintArrayReverse(int[] array, int index)
{
    if (index < 0) return;

    Console.Write(array[index] + " ");
    PrintArrayReverse(array, index - 1);

}
