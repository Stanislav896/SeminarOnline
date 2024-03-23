

//задаем исходный массив
int[] arr = new int[7] { 1, 3, 2, 4, 2, 3,6 };
// определяем  размер для результирующего массива
int size = arr.Length / 2;
//создаем новый массив
int[] result = new int[size];
//Через цикл заполняем массив произведения пар чисел из исходного массива




for (int i = 0; i < result.Length; i++)
{
    result[i] = arr[i] * arr[arr.Length - 1 - i]; //левый элемент масива умножаем на правый
                                                    // arr[i]-левый элемент. arr[arr.Length -1 -i]  
}
// Выводим результирующий массив в терминале
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}