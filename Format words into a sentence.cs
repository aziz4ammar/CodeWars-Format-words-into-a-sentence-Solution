using System;
using System.Linq;

public class Kata
{
    public static string FormatWords(string[] words)
    {
        if (words == null || words.Length == 0)
        {
            return "";
        }

        words = words.Where(word => !string.IsNullOrWhiteSpace(word)).ToArray();

        if (words.Length == 0)
        {
            return "";
        }

        if (words.Length == 1)
        {
            return words[0];
        }

        string lastWord = words.Last();
        string sentence = string.Join(", ", words.Take(words.Length - 1)) + " and " + lastWord;
        return sentence;
    }
}