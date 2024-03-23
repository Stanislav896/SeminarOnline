// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int count = -num;

    while (count <= num)
    {
        Console.Write(count + " ");
        count++; // count = count +1 // count += 1
    }
}
else
{
    Console.WriteLine("Некорректный ввод! ");
}


