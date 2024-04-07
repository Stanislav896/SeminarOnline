﻿//Напишите программу, которая будет принимать на вход число и
//возвращать сумму его цифр.
//Указание
//Использовать рекурсию.
//Пример
//123 => 6
//63 => 9

int SumDigit(int number) //123  12  1  0
{

    if (number == 0) return 0;
    return number % 10 + SumDigit(number / 10); //123  12  1   0
    //1*10+12*10+123*10+0=6
}

Console.WriteLine(SumDigit(123));