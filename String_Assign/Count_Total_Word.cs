using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assign
{
    public class Count_Total_Word
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sentence ");

            String sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            int count = words.Length;

            Console.WriteLine("Total number of words in string is = "+ count);


        }
    }
}
