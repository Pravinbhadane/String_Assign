using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assign
{
    public class Find_Word
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sentence ");
            String sentence1 = Console.ReadLine();

            String sentence = sentence1.ToLower();

            Console.WriteLine("Enter Word to find ");
            String word = Console.ReadLine();

            string findWord = word.ToLower();

            

            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == findWord)
                {
                    Console.WriteLine($"Word {findWord} Occures in sentence at no {i + 1}");
                    return;
                }
            }

            Console.WriteLine($"Word {findWord} is not present in given sentence");
        }
    }
}
