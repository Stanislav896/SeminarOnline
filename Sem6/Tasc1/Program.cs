







char[] chars = { 'a', 'b', 'c', 'd' };

string strResult = CharsArrayToString(chars);

Console.WriteLine(strResult);

string CharsArrayToString(char[] chars)
{
    string strResult = string.Empty;

    for (int i = 0; i < chars.Length; i++)
    {
        strResult += chars[i];
    }


    return strResult;
}