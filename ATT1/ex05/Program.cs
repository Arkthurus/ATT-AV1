using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra ou frase para verificar se é um palíndromo:");
        string input = Console.ReadLine();

        string normalized = RemoveAcentos(input);

        string cleaned = Regex.Replace(normalized, @"[^a-zA-Z0-9]", "").ToLower();

        bool isPalindrome = IsPalindrome(cleaned);

        if (isPalindrome)
        {
            Console.WriteLine("A palavra/frase é um palíndromo.");
        }
        else
        {
            Console.WriteLine("A palavra/frase não é um palíndromo.");
        }
    }

    static string RemoveAcentos(string text)
    {
        var normalizedString = text.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder();

        foreach (var c in normalizedString)
        {
            if (CharUnicodeInfo.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString();
    }

    static bool IsPalindrome(string text)
    {
        int len = text.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (text[i] != text[len - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}