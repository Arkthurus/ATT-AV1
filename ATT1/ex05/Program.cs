using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Verificador de palíndromos");
        Console.WriteLine("Digite uma palavra ou frase:");
        string input = Console.ReadLine();
        string cleanedInput = RemoveNonAlphanumeric(input).ToLower();
        bool isPalindrome = IsPalindrome(cleanedInput);

        if (isPalindrome)
        {
            Console.WriteLine("A frase ou palavra é um palíndromo.");
        }
        else
        {
            Console.WriteLine("A frase ou palavra não é um palíndromo.");
        }
    }
    static string RemoveNonAlphanumeric(string str)
    {
        char[] arr = str.ToCharArray();
        string result = "";
        foreach (char c in arr)
        {
            if (Char.IsLetterOrDigit(c))
            {
                result += c;
            }
        }
        return result;
    }
    static bool IsPalindrome(string str)
    {
        int len = str.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (str[i] != str[len - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
