Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int[] result = new int[3];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = number % 10;
        number /=  10;

    }
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + " ");

    }

}
else
{
    Console.WriteLine("Число не трехзначное");
}