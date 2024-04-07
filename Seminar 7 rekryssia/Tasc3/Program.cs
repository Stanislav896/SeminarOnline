//Считать строку с консоли, содержащую латинские буквы.
//Вывести на экран согласные буквы этой строки.
//Указание
//Использовать рекурсию. Не использовать цикл.
//Пример
//“hello” => h l l
//“World” => W r l d
//“Hello world!” => H l l w r l d



void PrintConsonans(string str, int count = 0)
{
    if (count == str.Length) return;
    string vowels = "aouyie";
    if (char.IsAsciiLetter(str[count]) == true && !vowels.Contains(char.ToLower(str[count])))
    {
        Console.Write(str[count] + " ");
    }
    PrintConsonans(str, count + 1);
}

void PrintConsonans2(string str)
{
    if (str.Length == 0) return;
    string vowels = "aouyie";
    if (char.IsAsciiLetter(str[0]) == true && !vowels.Contains(char.ToLower(str[0])))
    {
        Console.Write(str[0] + " ");
    }
    PrintConsonans2(str.Substring(1));
}

Console.WriteLine("Введите строку латинскими буквами");
string userInput = Console.ReadLine();

PrintConsonans(userInput);
PrintConsonans2(userInput);