//Задайте произвольную строку.

// Выясните, является ли она палиндромом.




Console.WriteLine("Введите строку");

string userInput = Console.ReadLine();

bool palindrome = true;


for (int i = 0; i < userInput.Length / 2; i++)
{
    if (userInput[i] != userInput[userInput.Length - i - 1])
    {
        palindrome = false;
        break;
    }
}

Console.WriteLine(palindrome ? "Строка палиндром" : "Строка не палиндром");




