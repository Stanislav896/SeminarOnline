﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
int result = 1;

if (num >= 100 && num <= 999 || num <= -100 && num >= -999)
{
    int digit2 = num / 10 % 10;
    int digit3 = num % 10;
//изменение знака третей степени цыфры, если значение изначального отрицательное
    if (digit3 <= 0  )
    {
        digit3 *= -1; //digit3 = digit3 * -1
    }

//
    while (count <= digit3)
    {
        result = result * digit2;
        count++;
    }

    if (digit3 < 0)
    {
        result = 1 / result;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("некорректный ввод");
}

// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2097152
// 254 => 5^4 = 625
// 617 => 1

// Console.WriteLine("Hello, World!");
