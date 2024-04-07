// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.




    Console.WriteLine("Введите число M и N");
    
        int M = Convert.ToInt32(Console.ReadLine()); // Начало диапазона
        int N = Convert.ToInt32(Console.ReadLine()); // Конец диапазона



    void RecursivePrintNumbers(int M, int N)
    {
        if (M > N)
        {
            return;
        }
        
            Console.Write(M + " ");
            RecursivePrintNumbers(M + 1, N);
        
    }
 RecursivePrintNumbers(M, N);
