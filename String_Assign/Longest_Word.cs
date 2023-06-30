using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assign
{
    public class Longest_Word
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sentence ");

            String sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            string longestWord="";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }
           
            Console.WriteLine(" Longest  word in string is = " + longestWord);


        }
    }
}
