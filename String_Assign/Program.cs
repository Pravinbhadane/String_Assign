using System;

public class Program
{
    public static void Main()
    {
        string text = "Hello, World!";
        Console.WriteLine("Original string: " + text);

        // Length
        int length = text.Length;
        Console.WriteLine("Length: " + length);

        // Substring
        string substring = text.Substring(7);
        Console.WriteLine("Substring from index 7: " + substring);

        // Concatenation
        string concatenated = string.Concat(text, " I'm here!");
        Console.WriteLine("Concatenated string: " + concatenated);

        // Upper case
        string upperCase = text.ToUpper();
        Console.WriteLine("Uppercase: " + upperCase);

        // Lower case
        string lowerCase = text.ToLower();
        Console.WriteLine("Lowercase: " + lowerCase);

        // Replace
        string replaced = text.Replace("World", "Universe");
        Console.WriteLine("Replaced string: " + replaced);

        // Index of
        int index = text.IndexOf(",");
        Console.WriteLine("Index of : " + index);

        // Trim
        string trimmed = "   Trim this!   ";
        string trimmedResult = trimmed.Trim();
        Console.WriteLine("Trimmed string: " + trimmedResult);

        // Split
        string sentence = "This is a sentence.";
        string[] words = sentence.Split(' ');
        Console.WriteLine("Split string: ");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // StartsWith
        bool startsWithHello = text.StartsWith("Hello");
        Console.WriteLine("Starts with 'Hello': " + startsWithHello);

        // EndsWith
        bool endsWithWorld = text.EndsWith("World!");
        Console.WriteLine("Ends with 'World!': " + endsWithWorld);

        // Contains
        bool containsHello = text.Contains("Hello");
        Console.WriteLine("Contains 'Hello': " + containsHello);
    }
}
