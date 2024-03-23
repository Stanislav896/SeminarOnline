int[] arr = new int[10] { -5, -3, 2, 4, 5, -2, -7, 8, 10, 2 };

for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1;
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}