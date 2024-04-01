







int CountNumberVowels(string str)
{
    string vowels = "aouyei";
    int count = 0;

     str = str.ToLower();
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                count++;
            }
        }
    }
    return count;
}
Console.WriteLine("Введите строку латинскими буквами");
string userInput = Console.ReadLine();

int resultCount = CountNumberVowels(userInput);
Console.WriteLine(resultCount);